using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.core.errors;
using webapi.src.core.utils;
using webapi.src.feature.todo.domain.entity;
using webapi.src.feature.todo.domain.repository;

namespace webapi.src.feature.todo.data.repository
{
    public class CityRepositoryImpl : CityRepository
    {
        public virtual Task<Pair<Failure, List<City>>> GetCities()
        {
            throw new NotImplementedException();
        }

    }
}
