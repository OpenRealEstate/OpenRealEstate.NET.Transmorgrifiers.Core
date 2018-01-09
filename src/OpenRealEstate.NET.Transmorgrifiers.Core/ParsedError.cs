namespace OpenRealEstate.NET.Transmorgrifiers.Core
{
    public class ParsedError
    {
        public ParsedError(string exceptionMessage,
                           string invalidData)
        {
            if (string.IsNullOrWhiteSpace(exceptionMessage))
            {
                throw new System.ArgumentException(nameof(exceptionMessage));
            }

            if (string.IsNullOrWhiteSpace(invalidData))
            {
                throw new System.ArgumentException(nameof(invalidData));
            }

            ExceptionMessage = exceptionMessage;
            InvalidData = invalidData;
        }

        /// <summary>
        /// The exception message that occured when trying to parse the data.
        /// </summary>
        public string ExceptionMessage { get; }

        /// <summary>
        /// The invalid data.
        /// </summary>
        public string InvalidData { get; }

        /// <summary>
        /// Agency/Office Identifier where the listing originated from.
        /// </summary>
        /// <remarks>Optional: If this key/element wasn't parsed, then this will be <code>null</code>.</remarks>
        public string AgencyId { get; set; }

        /// <summary>
        /// Unqiue (to the Agency) Listing Identifier.
        /// </summary>
        /// <remarks>Optional: If this key/element wasn't parsed, then this will be <code>null</code>.</remarks>
        public string ListingId { get; set; }
    }
}