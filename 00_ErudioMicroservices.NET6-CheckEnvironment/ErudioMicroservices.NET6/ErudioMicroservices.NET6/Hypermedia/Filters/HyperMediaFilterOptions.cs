using ErudioMicroservices.NET6.Hypermedia.Abstract;
using System.Collections.Generic;

namespace ErudioMicroservices.NET6.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
