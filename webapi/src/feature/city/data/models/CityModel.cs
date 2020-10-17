using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.feature.todo.domain.entity;

namespace webapi.src.feature.todo.data.models
{
    public class CityModel: City
    {
        public CityModel()
        {

        }

        public CityModel(long id, string name, string countryCode, string district, string population) :
         base(id: id, name:name, countryCode:countryCode, district:district, population:population)
        { }
    }
}

