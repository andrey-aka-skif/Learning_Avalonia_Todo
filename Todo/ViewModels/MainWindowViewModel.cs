using Todo.Services;

namespace Todo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public TodoListViewModel List { get; }

        public MainWindowViewModel(Database db)
        {
            List = new TodoListViewModel(db.GetItems());
        }
    }
}