using FluentAssertions;
using FluentAssertions.Common;
using System;
using System.Collections.Generic;
using System.Text;
using webapi.src.feature.todo.data.models;
using webapi.src.feature.todo.domain.entity;
using Xunit;

namespace tests.features.data.model
{
    public class CityModelUnitTest
    {
       
       

        [Fact]
        public void City_Should_Be_Same_As_CityModule()
        {
            // Arrrange
            CityModel cityModel = new CityModel 
            { 
                Id = 423423423, 
                Name = "Poland", 
                CountryCode = "pol", 
                District = "poland", 
                Population = "38000000000" 
            };


            City city = new City
            {
                Id = 423423423,
                Name = "Poland",
                CountryCode = "pol",
                District = "poland",
                Population = "38000000000"
            };

            // Act
            ////////////////
            // Assert
            cityModel.Should().Be(cityModel);
            cityModel.Should().Be(city);
            cityModel.Should().As<City>();
        }
    }
}
