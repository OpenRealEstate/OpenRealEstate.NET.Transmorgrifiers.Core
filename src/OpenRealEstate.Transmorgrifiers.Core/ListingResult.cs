using System.Collections.Generic;
using OpenRealEstate.Core;

namespace OpenRealEstate.Transmorgrifiers.Core
{
    public class ListingResult
    {
        public Listing Listing { get; set; }
        public string SourceData { get; set; }
        public IList<string> Warnings { get; set; }

        public override string ToString()
        {
            return $"Type: {Listing?.ToString() ?? "-null -"}";
        }
    }
}
