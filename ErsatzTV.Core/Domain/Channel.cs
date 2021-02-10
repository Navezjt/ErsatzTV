﻿using System;
using System.Collections.Generic;

namespace ErsatzTV.Core.Domain
{
    public class Channel
    {
        public Channel(Guid uniqueId) => UniqueId = uniqueId;

        public int Id { get; set; }
        public Guid UniqueId { get; init; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public int FFmpegProfileId { get; set; }
        public FFmpegProfile FFmpegProfile { get; set; }
        public StreamingMode StreamingMode { get; set; }

        public List<Playout> Playouts { get; set; }
        // public SourceMode Mode { get; set; }
    }
}