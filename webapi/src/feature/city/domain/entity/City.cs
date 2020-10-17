using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.src.feature.todo.domain.entity
{
    public class City : IEquatable<City>
    {
        public City()
        {

        }
        public City(long id, string name, string countryCode, string district, string population)
        {
            Id = id;
            Name = name;
            CountryCode = countryCode;
            District = district;
            Population = population;
        }

        public long Id { get; set; }


        public string Name { get; set; }


        public string CountryCode { get; set; }



        public string District { get; set; }


        public string Population { get; set; }

        public bool Equals([AllowNull] City other)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as City);
        }
    }
}
