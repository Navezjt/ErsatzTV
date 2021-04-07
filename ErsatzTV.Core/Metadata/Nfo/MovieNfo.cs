﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ErsatzTV.Core.Metadata.Nfo
{
    [XmlRoot("movie")]
    public class MovieNfo
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("outline")]
        public string Outline { get; set; }

        [XmlElement("year")]
        public int Year { get; set; }

        [XmlElement("mpaa")]
        public string ContentRating { get; set; }

        [XmlElement("premiered")]
        public DateTime Premiered { get; set; }

        [XmlElement("plot")]
        public string Plot { get; set; }

        [XmlElement("tagline")]
        public string Tagline { get; set; }

        [XmlElement("genre")]
        public List<string> Genres { get; set; }

        [XmlElement("tag")]
        public List<string> Tags { get; set; }

        [XmlElement("studio")]
        public List<string> Studios { get; set; }
    }
}