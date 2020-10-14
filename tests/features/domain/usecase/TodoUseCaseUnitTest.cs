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
    public class TodoUseCaseUnitTest
    {
        private readonly Mock<TodoRepository> todoRepository;
        private readonly GetTodoUseCase getTodoUseCase;
        private List<Todo> todos;
        private Pair<Failure, List<Todo>> pair;

        public TodoUseCaseUnitTest()
        {
            todoRepository = new Mock<TodoRepository>();
            getTodoUseCase = new GetTodoUseCase(todoRepository.Object);
            todos = new List<Todo>();
            pair = new Pair<Failure, List<Todo>>(null, todos);
        }

        [Fact]
        public async void GetToDoUseCase_Should_Call_GetToDo_When_Execiuted()
        {
            // Arrange
            todoRepository.Setup(m => m.GetTodos()).Returns(Task.FromResult(pair));
            // Act
           var result = await getTodoUseCase.execiute(It.IsAny<NoParams>());
            // Asert
            result.Should().Be(pair);
        }
    }
}
