﻿using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using ErsatzTV.Core;
using ErsatzTV.Core.Interfaces.Plex;
using LanguageExt;
using MediatR;
using static LanguageExt.Prelude;

namespace ErsatzTV.Application.MediaSources.Commands
{
    public class StartPlexPinFlowHandler : IRequestHandler<StartPlexPinFlow, Either<BaseError, string>>
    {
        private readonly ChannelWriter<IPlexBackgroundServiceRequest> _channel;
        private readonly IPlexTvApiClient _plexTvApiClient;

        public StartPlexPinFlowHandler(
            IPlexTvApiClient plexTvApiClient,
            ChannelWriter<IPlexBackgroundServiceRequest> channel)
        {
            _plexTvApiClient = plexTvApiClient;
            _channel = channel;
        }

        public Task<Either<BaseError, string>> Handle(
            StartPlexPinFlow request,
            CancellationToken cancellationToken) =>
            _plexTvApiClient.StartPinFlow().Bind(
                result => result.Match(
                    Left: error => Task.FromResult(Left<BaseError, string>(error)),
                    Right: async pin =>
                    {
                        await _channel.WriteAsync(new TryCompletePlexPinFlow(pin), cancellationToken);
                        return Right<BaseError, string>(pin.Url);
                    })
            );
    }
}