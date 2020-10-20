using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.src.core.config
{
    public class LocalDataInjector : IInjector
    {
        public void Init(IConfiguration configuration, IServiceCollection services)
        {
            throw new NotImplementedException();
        }
    }
}
