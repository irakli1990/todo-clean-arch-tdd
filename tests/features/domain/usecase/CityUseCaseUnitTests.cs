using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.src.core.errors;
using webapi.src.core.noparam;
using webapi.src.core.utils;
using webapi.src.feature.todo.domain.entity;
using webapi.src.feature.todo.domain.repository;
using webapi.src.feature.todo.domain.usecase;
using Xunit;

namespace tests
{
    public class CityUseCaseUnitTests
    {
        private readonly Mock<CityRepository> todoRepository;
        private readonly GetCitiesUseCase getTodoUseCase;
        private List<City> todos;
        private Pair<Failure, List<City>> pair;

        public CityUseCaseUnitTests()
        {
            todoRepository = new Mock<CityRepository>();
            getTodoUseCase = new GetCitiesUseCase(todoRepository.Object);
            todos = new List<City>();
            pair = new Pair<Failure, List<City>>(null, todos);
        }

        [Fact]
        public async void GetToDoUseCase_Should_Call_GetToDo_When_Execiuted()
        {
            // Arrange
            todoRepository.Setup(m => m.GetCities()).Returns(Task.FromResult(pair));
            // Act
           var result = await getTodoUseCase.execiute(It.IsAny<NoParams>());
            // Asert
            result.Should().Be(pair);
        }
    }
}
