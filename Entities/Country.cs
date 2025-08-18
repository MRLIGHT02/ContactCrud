namespace Entities
{
    /// <summary>
    /// This is a Domain Model to, Represents a country with a unique identifier and a name.
    /// </summary>
    /// <remarks>This class is used to store and manage information about a country, including its unique
    /// identifier and name. Both properties are mutable, allowing updates to the country's details.</remarks>
    public class Country
    {
        public Guid CountryId { get; set; }
        public string? CountryName { get; set; }

    }
}
