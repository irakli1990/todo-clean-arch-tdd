using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.core.database;

namespace webapi.src.core.config
{
    public class DataContextInjector : IInjector
    {
        public void Init(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<DataBaseContext>(options => options.UseMySQL(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
