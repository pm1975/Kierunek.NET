﻿using System.Windows;
using ToDoList.Core.Helpers;
using ToDoList.Database;

namespace ToDoList.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var database = new ToDoListDbContext();

            database.Database.EnsureCreated();

            DatabaseLocator.Database = database;
        }
    }
}
