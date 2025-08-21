using BenchmarkDotNet.Attributes;
using Entities;
using ServiceContracts;
using ServiceContracts.DTO;
using Services;
using System;
using System.Collections.Generic;


namespace ContactTest
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService _countriesService;
        
        public CountriesServiceTest(CountriesService countriesService)
        {
            _countriesService = countriesService;

        }

        // When CountryRequest is null, the method should throw an ArgumentNullException
        [Fact]
        public void AddCountry_NullCountryRequest_ThrowsArgumentNullException()
        {
            // Arrange
            CountryAddRequest? request = null;
            // Act & Assert

            Assert.Throws<ArgumentNullException>(() => _countriesService.AddCountry(request));

        }
        // When CountryName is null, it should throw an ArgumentNullException
        [Fact]
        public void AddCountry_NullCountryName_ThrowsArgumentException()
        {
            // Arrange
            CountryAddRequest? request = new CountryAddRequest() { CountryName=null};
            // Act & Assert

            Assert.Throws<ArgumentException>(() => _countriesService.AddCountry(request));

        }
        //When the CountryName is duplicate, it should throw ArgumentException
        [Fact]
        public void AddCountry_DoubleCountryNameOrSimialar_ArgumentException()
        {
            // Arrange
            //Arrange
            CountryAddRequest? request1 = new CountryAddRequest() { CountryName = "USA" };
            CountryAddRequest? request2 = new CountryAddRequest() { CountryName = "USA" };
            // Act & Assert

            Assert.Throws<ArgumentException>(() =>
            {
                _countriesService.AddCountry(request1);
                _countriesService.AddCountry(request2);
            });

        }

        //When you supply proper country name, it should insert (add) the country to the existing list of countries
        [Fact]
        public void AddCountry_ProperCountryDetails()
        {
            //Arrange
            CountryAddRequest? request = new CountryAddRequest() { CountryName = "india" };

            //Act
            CountryResponse response = _countriesService.AddCountry(request);
            

            //Assert
            Assert.True(response.CountryId != Guid.Empty);
            
        }

        




    }
}
