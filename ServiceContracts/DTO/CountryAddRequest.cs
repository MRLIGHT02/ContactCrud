using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    /// <summary>
    /// DTO class to represents a request to add a new country.
    /// </summary>
    /// <remarks>This class is used to encapsulate the data required to create a new country entry.</remarks>
    public class CountryAddRequest
    {
        public string? CountryName { get; set; }

        public Country ToCountry()
        {
            return new Country() { CountryName = this.CountryName };
        }

        

    }
}
