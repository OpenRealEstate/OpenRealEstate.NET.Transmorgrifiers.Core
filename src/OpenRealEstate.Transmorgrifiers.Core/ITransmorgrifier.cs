using System.Threading.Tasks;
using OpenRealEstate.Core;

namespace OpenRealEstate.Transmorgrifiers.Core
{
    public interface ITransmorgrifier
    {
        /// <summary>
        /// Name of this transmorgrifier.
        /// </summary>
        /// <remarks>This name is mainly used as an audit reference in case later on you need to figure out what parsed this data and possible, re-parse it again.</remarks>
        string Name { get; }

        /// <summary>
        /// Parses and converts some given data into a listing instance.
        /// </summary>
        /// <param name="data">some data source, like Xml data or json data.</param>
        /// <param name="existingListing">An optional destination listing which will extract any data, into.</param>
        /// <param name="areBadCharactersRemoved">Help clean up the data.</param>
        /// <returns>List of listings, unhandled data and/or errors.</returns>
        /// <remarks>The <code>existing listing</code> that is provided will end up be used in the <code>ParsedResult</code> result, but with new data populated into it.</remarks>
        Task<ParsedResult> ParseAsync(string data,
                                      Listing existingListing = null,
                                      bool areBadCharactersRemoved = false);
    }
}
