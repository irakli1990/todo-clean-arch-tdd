using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using webapi.src.core.errors;
using webapi.src.core.utils;
using webapi.src.feature.city.data.datasource;
using webapi.src.feature.todo.domain.entity;
using webapi.src.feature.todo.domain.repository;

namespace webapi.src.feature.todo.data.repository
{
    public class CityRepositoryImpl : CityRepository
    {
        private readonly CityLocalDataSource cityLocalDataSource;
        public CityRepositoryImpl(CityLocalDataSource cityLocalDataSource)
        {
            this.cityLocalDataSource = cityLocalDataSource;
        }
        public async virtual  Task<Pair<Failure, List<City>>> GetCities()
        {
            try
            {
                var cities = await this.cityLocalDataSource.GetCities();
                return null;
            }
            catch (ServerException e)
            {
                return new Pair<Failure, List<City>>(new ServerFailure(), null);
            }
        }

    }
}
