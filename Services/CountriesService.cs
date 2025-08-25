using Entities;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{

    public class CountriesService : ICountriesService
    {
        // private readonly List<Country> _countries;

        private readonly List<Country> _countries;

        public CountriesService(List<Country> countries)
        {
            _countries = countries;
        }

        public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
        {
            // Convert object from CountryAddRequest to Country

            Country country = countryAddRequest!.ToCountry();
            // Generate a new Guid for the country
            country.CountryId = Guid.NewGuid();
            

            _countries.Add(country);
            return country.ToCountryResponse();
        }
    }
}
