using System;

namespace OpenRealEstate.NET.Transmorgrifiers.Core
{
    public class ParsingException : Exception
    {
        public ParsingException(string message,
                                string agencyId,
                                string listingId,
                                Exception exception) : base(message, exception)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("A error message is required.", nameof(message));
            }

            if (exception == null)
            {
                throw new ArgumentNullException(nameof(exception));
            }

            AgencyId = agencyId;
            ListingId = listingId;
        }

        public string AgencyId { get; }
        public string ListingId { get; }
    }
}