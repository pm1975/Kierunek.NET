
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace ToDoList.Core
{
    public class WorkTasksPageViewModel
    {

        public List<WorkTaskViewModel> WorkTaskList { get; set; } = new List<WorkTaskViewModel>();

        public string NewWorkTaskTitle { get; set; }

        public string NewWorkTaskDescription { get; set; }

        public ICommand AddNewTaskCommand { get; set; }

        public WorkTasksPageViewModel()
        {
            AddNewTaskCommand = new RelayCommand(AddNewTask);
        }

        private void AddNewTask()
        {
            var newTask = new WorkTaskViewModel
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreateDate = DateTime.Now
            };

            WorkTaskList.Add(newTask);
        }
    }
}
