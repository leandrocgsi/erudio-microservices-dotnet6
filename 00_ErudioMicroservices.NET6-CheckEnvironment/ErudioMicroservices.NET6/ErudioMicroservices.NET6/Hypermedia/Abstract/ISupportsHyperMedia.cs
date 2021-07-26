using System.Collections.Generic;

namespace ErudioMicroservices.NET6.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
