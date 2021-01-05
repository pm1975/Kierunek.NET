using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Database;

namespace ToDoList.Core.Helpers
{
    public class DatabaseLocator
    {
        public static ToDoListDbContext Database { get; set; }
    }
}
