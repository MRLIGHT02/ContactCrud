using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Represent business Logic for manipulating Country entity
    /// </summary>
    public interface ICountriesService
    {
        
        /// <summary>
        /// Add a country object to the list of countries
        /// </summary>
        /// <param name="countryAddRequest">Country object to add </param>
        /// <returns>Returns the Country object after adding it (including newly generated country id)</returns>
       public CountryResponse AddCountry(CountryAddRequest? countryAddRequest);
    }
}
