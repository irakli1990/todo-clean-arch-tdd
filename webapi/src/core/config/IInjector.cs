using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.feature.city.data.datasource;
using webapi.src.feature.todo.data.repository;
using webapi.src.feature.todo.domain.repository;
using webapi.src.feature.todo.domain.usecase;

namespace webapi.src.core.config
{
    public interface IInjector
    {
        void Init(IConfiguration configuration, IServiceCollection services);
    }
}
