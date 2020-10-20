using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.core.database;
using webapi.src.core.errors;
using webapi.src.feature.todo.data.models;
using webapi.src.feature.todo.domain.entity;

namespace webapi.src.feature.city.data.datasource
{
    public interface CityLocalDataSource
    {


        public Task<List<CityModel>> GetCities();

        public Task DelteCity(CityModel city);

        public Task<CityModel> GetCityById(long id);

        public Task<CityModel> EditCity(CityModel city);



    }
    public class CityLocalDataSourceImpl : CityLocalDataSource
    {
        private readonly DataBaseContext _context;


        public CityLocalDataSourceImpl(DataBaseContext context)
        {
            _context = context;
        }

        public Task DelteCity(CityModel city)
        {
            var result = this._context.cities.Remove(city);
            if(result.State == EntityState.Deleted)
            {
                return null;
            }
            else
            {
                throw new ServerException();
            }
         
        }

        public Task<CityModel> EditCity(CityModel city)
        {
            throw new NotImplementedException();
        }

        public Task<List<CityModel>> GetCities()
        {
            var cities = _context.cities.ToList();
            if (cities != null)
            {
                return Task.FromResult(cities);
            }
            else
            {
                throw new ServerException();
            }
        }

     

        public Task<CityModel> GetCityById(long id)
        {
            try
            {
                var city = this._context.cities.Find(id);
                return Task.FromResult(city);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    
    }
}
