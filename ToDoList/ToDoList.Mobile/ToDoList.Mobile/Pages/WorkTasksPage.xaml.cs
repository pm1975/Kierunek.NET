using ToDoList.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkTasksPage : ContentPage
    {
        public WorkTasksPage()
        {
            InitializeComponent();

            BindingContext = new WorkTasksPageViewModel();
        }
    }
}