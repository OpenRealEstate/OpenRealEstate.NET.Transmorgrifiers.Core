using System.Collections.Generic;

namespace OpenRealEstate.Transmorgrifiers.Core
{
    public class ParsedResult
    {
        public ParsedResult()
        {
            Listings = new List<ListingResult>();
            UnhandledData = new List<string>();
            Errors = new List<ParsedError>();
        }

        public ParsedResult(ParsedError error) : this()
        {
            if (error == null)
            {
                throw new System.ArgumentNullException(nameof(error));
            }

            Errors = new List<ParsedError> {error};
        }

        /// <summary>
        /// Successfully parsed listings.
        /// </summary>
        public IList<ListingResult> Listings { get; set; }

        /// <summary>
        /// Xml elements (children to the root node) that are not handled.
        /// </summary>
        public IList<string> UnhandledData { get; set; }

        /// <summary>
        /// Xml elements that failed to be parsed / contained bad data / etc.
        /// </summary>
        public IList<ParsedError> Errors { get; set; }
    }
}