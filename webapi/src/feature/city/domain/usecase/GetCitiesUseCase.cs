using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.core;
using webapi.src.core.errors;
using webapi.src.core.noparam;
using webapi.src.core.utils;
using webapi.src.feature.todo.domain.entity;
using webapi.src.feature.todo.domain.repository;

namespace webapi.src.feature.todo.domain.usecase
{
    public class GetCitiesUseCase : UseCase<List<City>, NoParams>
    {
        private readonly CityRepository todoRepository;

        public GetCitiesUseCase(CityRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public Task<Pair<Failure, List<City>>> execiute(NoParams @params)
        {
            return this.todoRepository.GetCities();
        }
    }

    
}