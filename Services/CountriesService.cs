using Entities;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{

    public class CountriesService : ICountriesService
    {
        // private readonly List<Country> _countries;

        private readonly List<Country> _countries;

       public CountriesService()
        {
            _countries = new List<Country>();
        }

        public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
        {
            // validation: countryAddRequest should not be null 
            if(countryAddRequest == null)
            {
                throw new ArgumentNullException(nameof(countryAddRequest));
            }
            // validation: CountryName should not be null/empty/whitespace
            if(countryAddRequest.CountryName == null || countryAddRequest.CountryName.Trim().Length == 0)
            {
                throw new ArgumentException("Country Name cannot be null/empty/whitespace");
            }

            if (_countries.Where(temp => temp.CountryName == countryAddRequest.CountryName).Count()>0)
            {
                throw new ArgumentException("Country Name cannot be duplicate");
            }
            // Convert object from CountryAddRequest to Country

            Country country = countryAddRequest!.ToCountry();
         
            // Generate a new Guid for the country
            country.CountryId = Guid.NewGuid();
            

            _countries.Add(country);
           
            return country.ToCountryResponse();
        }
    }
}
