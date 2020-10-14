using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.core.errors;
using webapi.src.core.utils;

namespace webapi.src.core
{
    public interface UseCase<Type, Params>
    {
        Task<Pair<Failure, Type>> execiute(Params @params);
    }
}
