using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.feature.todo.data.models;

namespace webapi.src.core.database
{
    public class DataBaseContext: DbContext
    {

        public DbSet<CityModel> cities;
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user id=root;persistsecurityinfo=True;database=world");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
