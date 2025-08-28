using Entities;

namespace ServiceContracts.DTO
{
    /// <summary>
    /// Represents a response containing information about a country.
    /// </summary>
    /// <remarks>This class is typically used to encapsulate country-related data in API responses.</remarks>
    public class CountryResponse
    {
        public Guid CountryId { get; set; }
        public string? CountryName { get; set; }




    }
    /// <summary>
    /// Provides extension methods for the <see cref="Country"/> type.
    /// </summary>
    /// <remarks>This class contains methods that extend the functionality of the <see cref="Country"/> type,
    /// enabling additional operations such as converting a <see cref="Country"/> instance to a <see
    /// cref="CountryResponse"/>.</remarks>
    public static class CountryExtensions
    {

        public static CountryResponse ToCountryResponse(this Country country)
        {
            return new CountryResponse() {CountryId = country.CountryId,CountryName = country.CountryName};

        }

    }

}
