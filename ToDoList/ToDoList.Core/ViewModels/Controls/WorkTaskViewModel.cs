
using System;

namespace ToDoList.Core
{
    public class WorkTaskViewModel : BaseViewModel
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
