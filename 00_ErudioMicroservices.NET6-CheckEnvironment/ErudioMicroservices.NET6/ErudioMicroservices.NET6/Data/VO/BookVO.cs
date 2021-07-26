using ErudioMicroservices.NET6.Hypermedia;
using ErudioMicroservices.NET6.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace ErudioMicroservices.NET6.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime LaunchDate { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}