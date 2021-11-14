using System.Collections.Generic;
using System.Collections.ObjectModel;
using Todo.Models.Todo.Models;

namespace Todo.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public ObservableCollection<TodoItem> Items { get; }

        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
        }
    }
}