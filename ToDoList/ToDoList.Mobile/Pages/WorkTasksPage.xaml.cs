using ToDoList.Core;
using Xamarin.Forms;

namespace ToDoList.Mobile
{
    public partial class WorkTasksPage : ContentPage
    {
        public WorkTasksPage()
        {
            InitializeComponent();

            BindingContext = new WorkTasksPageViewModel();
        }
    }
}
