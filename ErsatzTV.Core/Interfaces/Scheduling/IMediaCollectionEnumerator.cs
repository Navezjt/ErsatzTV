﻿using ErsatzTV.Core.Domain;
using LanguageExt;

namespace ErsatzTV.Core.Interfaces.Scheduling
{
    public interface IMediaCollectionEnumerator
    {
        MediaCollectionEnumeratorState State { get; }
        public Option<MediaItem> Current { get; }
        public Option<MediaItem> Peek { get; }
        public void MoveNext();
    }
}