using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.core.errors;
using webapi.src.core.utils;
using webapi.src.feature.todo.domain.entity;

namespace webapi.src.feature.todo.domain.repository
{
    public interface TodoRepository
    {
        Task<Pair<Failure, List<Todo>>> GetTodos();
    }
}
