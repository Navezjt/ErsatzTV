﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ErsatzTV.Core.Domain;
using ErsatzTV.Core.Interfaces.Metadata;
using ErsatzTV.Core.Interfaces.Repositories;
using LanguageExt;
using Newtonsoft.Json;
using static LanguageExt.Prelude;

namespace ErsatzTV.Core.Metadata
{
    public class LocalStatisticsProvider : ILocalStatisticsProvider
    {
        private readonly IMediaItemRepository _mediaItemRepository;

        public LocalStatisticsProvider(IMediaItemRepository mediaItemRepository) =>
            _mediaItemRepository = mediaItemRepository;

        public async Task RefreshStatistics(string ffprobePath, MediaItem mediaItem)
        {
            FFprobe ffprobe = await GetProbeOutput(ffprobePath, mediaItem);
            MediaMetadata metadata = ProjectToMediaMetadata(ffprobe);
            await ApplyStatisticsUpdate(mediaItem, metadata);
        }

        private async Task ApplyStatisticsUpdate(
            MediaItem mediaItem,
            MediaMetadata metadata)
        {
            if (mediaItem.Metadata == null)
            {
                mediaItem.Metadata = new MediaMetadata();
            }

            mediaItem.Metadata.Duration = metadata.Duration;
            mediaItem.Metadata.AudioCodec = metadata.AudioCodec;
            mediaItem.Metadata.SampleAspectRatio = metadata.SampleAspectRatio;
            mediaItem.Metadata.DisplayAspectRatio = metadata.DisplayAspectRatio;
            mediaItem.Metadata.Width = metadata.Width;
            mediaItem.Metadata.Height = metadata.Height;
            mediaItem.Metadata.VideoCodec = metadata.VideoCodec;
            mediaItem.Metadata.VideoScanType = metadata.VideoScanType;

            await _mediaItemRepository.Update(mediaItem);
        }

        private Task<FFprobe> GetProbeOutput(string ffprobePath, MediaItem mediaItem)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = ffprobePath,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            startInfo.ArgumentList.Add("-v");
            startInfo.ArgumentList.Add("quiet");
            startInfo.ArgumentList.Add("-print_format");
            startInfo.ArgumentList.Add("json");
            startInfo.ArgumentList.Add("-show_format");
            startInfo.ArgumentList.Add("-show_streams");
            startInfo.ArgumentList.Add("-i");
            startInfo.ArgumentList.Add(mediaItem.Path);

            var probe = new Process
            {
                StartInfo = startInfo
            };

            probe.Start();
            return probe.StandardOutput.ReadToEndAsync().MapAsync(
                async output =>
                {
                    await probe.WaitForExitAsync();
                    return JsonConvert.DeserializeObject<FFprobe>(output);
                });
        }

        private MediaMetadata ProjectToMediaMetadata(FFprobe probeOutput) =>
            Optional(probeOutput)
                .Filter(json => json != null)
                .ToValidation<BaseError>("Unable to parse ffprobe output")
                .ToEither<FFprobe>()
                .Match(
                    json =>
                    {
                        var duration = TimeSpan.FromSeconds(double.Parse(json.format.duration));

                        var metadata = new MediaMetadata { Duration = duration };

                        FFprobeStream audioStream = json.streams.FirstOrDefault(s => s.codec_type == "audio");
                        if (audioStream != null)
                        {
                            metadata = metadata with
                            {
                                AudioCodec = audioStream.codec_name
                            };
                        }

                        FFprobeStream videoStream = json.streams.FirstOrDefault(s => s.codec_type == "video");
                        if (videoStream != null)
                        {
                            metadata = metadata with
                            {
                                SampleAspectRatio = videoStream.sample_aspect_ratio,
                                DisplayAspectRatio = videoStream.display_aspect_ratio,
                                Width = videoStream.width,
                                Height = videoStream.height,
                                VideoCodec = videoStream.codec_name,
                                VideoScanType = ScanTypeFromFieldOrder(videoStream.field_order)
                            };
                        }

                        return metadata;
                    },
                    _ => new MediaMetadata());

        private VideoScanType ScanTypeFromFieldOrder(string fieldOrder) =>
            fieldOrder?.ToLowerInvariant() switch
            {
                var x when x == "tt" || x == "bb" || x == "tb" || x == "bt" => VideoScanType.Interlaced,
                "progressive" => VideoScanType.Progressive,
                _ => VideoScanType.Unknown
            };

        // ReSharper disable InconsistentNaming
        public record FFprobe(FFprobeFormat format, List<FFprobeStream> streams);

        public record FFprobeFormat(string duration);

        public record FFprobeStream(
            int index,
            string codec_name,
            string codec_type,
            int width,
            int height,
            string sample_aspect_ratio,
            string display_aspect_ratio,
            string field_order,
            string r_frame_rate);
        // ReSharper restore InconsistentNaming
    }
}