using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.feature.todo.data.models;
using webapi.src.feature.todo.domain.entity;

namespace webapi.src.feature.city.data.datasource
{
    public interface CityLocalDataSource
    {


        public List<CityModel> GetCity();

        public void DelteCity(CityModel city);

        public CityModel GetCityById(long id);

        public CityModel EditCity(CityModel city);



    }
    public class CityLocalDataSourceImpl : DbContext, CityLocalDataSource
    {
        public DbSet<CityModel> cityModels { get; set; }
        CityLocalDataSourceImpl(DbContextOptions<CityLocalDataSourceImpl> options) : base(options)
        {

        }

        public List<CityModel> GetCity()
        {
            try
            {
                return this.cityModels.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DelteCity(CityModel city)
        {
            try
            {
                this.cityModels.Remove(city);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public CityModel GetCityById(long id)
        {
            try
            {
                return this.cityModels.Find(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public CityModel EditCity(CityModel city)
        {
            try
            {
                var result = this.GetCityById(city.Id);
                if (result != null)
                {
                    result.Name = city.Name;
                    result.CountryCode = city.CountryCode;
                    result.District = city.District;
                    result.Population = city.Population;
                }

                this.cityModels.Add(result);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
