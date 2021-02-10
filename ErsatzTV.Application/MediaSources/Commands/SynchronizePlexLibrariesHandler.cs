﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ErsatzTV.Core;
using ErsatzTV.Core.Domain;
using ErsatzTV.Core.Interfaces.Plex;
using ErsatzTV.Core.Interfaces.Repositories;
using ErsatzTV.Core.Plex;
using LanguageExt;
using Microsoft.Extensions.Logging;

namespace ErsatzTV.Application.MediaSources.Commands
{
    public class
        SynchronizePlexLibrariesHandler : MediatR.IRequestHandler<SynchronizePlexLibraries, Either<BaseError, Unit>>
    {
        private readonly ILogger<SynchronizePlexLibrariesHandler> _logger;
        private readonly IMediaSourceRepository _mediaSourceRepository;
        private readonly IPlexSecretStore _plexSecretStore;
        private readonly IPlexServerApiClient _plexServerApiClient;

        public SynchronizePlexLibrariesHandler(
            IMediaSourceRepository mediaSourceRepository,
            IPlexSecretStore plexSecretStore,
            IPlexServerApiClient plexServerApiClient,
            ILogger<SynchronizePlexLibrariesHandler> logger)
        {
            _mediaSourceRepository = mediaSourceRepository;
            _plexSecretStore = plexSecretStore;
            _plexServerApiClient = plexServerApiClient;
            _logger = logger;
        }

        public Task<Either<BaseError, Unit>> Handle(
            SynchronizePlexLibraries request,
            CancellationToken cancellationToken) =>
            Validate(request)
                .MapT(SynchronizeLibraries)
                .Bind(v => v.ToEitherAsync());

        private Task<Validation<BaseError, ConnectionParameters>> Validate(SynchronizePlexLibraries request) =>
            MediaSourceMustExist(request)
                .BindT(MediaSourceMustHaveActiveConnection)
                .BindT(MediaSourceMustHaveToken);

        private Task<Validation<BaseError, PlexMediaSource>> MediaSourceMustExist(SynchronizePlexLibraries request) =>
            _mediaSourceRepository.GetPlex(request.PlexMediaSourceId)
                .Map(o => o.ToValidation<BaseError>("Plex media source does not exist."));

        private Validation<BaseError, ConnectionParameters> MediaSourceMustHaveActiveConnection(
            PlexMediaSource plexMediaSource)
        {
            Option<PlexMediaSourceConnection> maybeConnection =
                plexMediaSource.Connections.SingleOrDefault(c => c.IsActive);
            return maybeConnection.Map(connection => new ConnectionParameters(plexMediaSource, connection))
                .ToValidation<BaseError>("Plex media source requires an active connection");
        }

        private async Task<Validation<BaseError, ConnectionParameters>> MediaSourceMustHaveToken(
            ConnectionParameters connectionParameters)
        {
            Option<PlexServerAuthToken> maybeToken = await
                _plexSecretStore.GetServerAuthToken(connectionParameters.PlexMediaSource.ClientIdentifier);
            return maybeToken.Map(token => connectionParameters with { PlexServerAuthToken = token })
                .ToValidation<BaseError>("Plex media source requires a token");
        }

        private async Task<Unit> SynchronizeLibraries(ConnectionParameters connectionParameters)
        {
            Either<BaseError, List<PlexMediaSourceLibrary>> maybeLibraries = await _plexServerApiClient.GetLibraries(
                connectionParameters.ActiveConnection,
                connectionParameters.PlexServerAuthToken);

            await maybeLibraries.Match(
                libraries =>
                {
                    List<PlexMediaSourceLibrary> existing = connectionParameters.PlexMediaSource.Libraries;
                    var toAdd = libraries.Filter(library => existing.All(l => l.Key != library.Key)).ToList();
                    var toRemove = existing.Filter(library => libraries.All(l => l.Key != library.Key)).ToList();
                    existing.AddRange(toAdd);
                    toRemove.ForEach(c => existing.Remove(c));

                    return _mediaSourceRepository.Update(connectionParameters.PlexMediaSource);
                },
                error =>
                {
                    _logger.LogWarning(
                        "Unable to synchronize libraries from Plex server {PlexServer}: {Error}",
                        connectionParameters.PlexMediaSource.Name,
                        error.Value);

                    return Task.CompletedTask;
                });

            return Unit.Default;
        }

        private record ConnectionParameters(
            PlexMediaSource PlexMediaSource,
            PlexMediaSourceConnection ActiveConnection)
        {
            public PlexServerAuthToken PlexServerAuthToken { get; set; }
        }
    }
}