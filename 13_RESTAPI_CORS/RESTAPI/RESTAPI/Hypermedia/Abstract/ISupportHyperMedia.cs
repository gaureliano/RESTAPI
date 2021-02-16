using System.Collections.Generic;

namespace RESTAPI.Hypermedia.Abstract
{
    public interface ISupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }

    }
}
