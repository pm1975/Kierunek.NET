using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Database
{
    public class WorkTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
