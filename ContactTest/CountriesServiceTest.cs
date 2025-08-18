using ServiceContracts;
using Entities;
using System;
using System.Collections.Generic;
using Services;


namespace ContactTest
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService _countriesService;
        
        public CountriesServiceTest()
        {
            _countriesService =new CountriesService();

        }

    }
}
