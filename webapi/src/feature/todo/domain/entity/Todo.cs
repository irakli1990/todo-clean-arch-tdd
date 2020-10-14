using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.src.feature.todo.domain.entity
{
    public class Todo
    {
        
        public long Id { get; set; }


        public string Text { get; set; }

         
        public bool IsComplete { get; set; }
    }
}
