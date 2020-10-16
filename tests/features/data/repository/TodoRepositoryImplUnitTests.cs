using FluentAssertions;
using Moq;
using System;
using webapi.src.feature.todo.data.repository;
using Xunit;

namespace tests.features.data.repository
{
    public class TodoRepositoryImplUnitTests
    {
        private Mock<CityRepositoryImpl> todoRepository;

        public TodoRepositoryImplUnitTests()
        {
            todoRepository = new Mock<CityRepositoryImpl>();
        }

        [Fact]
        public void Should_Throw_NotIMplemented_exception()
        {
            // Arrange
            todoRepository.Setup(x => x.GetCities())
         .Throws<NotImplementedException>();

            CityRepositoryImpl todoRepositoryImpl = todoRepository.Object;

            // Act

            Action action = () => todoRepositoryImpl.GetCities();


            // Assert

            action.Should().Throw<NotImplementedException>();

        }
    }
}
