using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Todo.UI.Models;

namespace Todo.UI.ViewModels
{
    public partial class TodoListViewModel : ObservableObject
    {
		[ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddTodoCommand))]
        private string _newTodoTitle;
        //public string NewTodoTitle
        //{
        //	get 
        //	{ 
        //		return _newTodoTitle; 
        //	}
        //	set 
        //	{ 
        //		_newTodoTitle = value;
        //		OnPropertyChanged();
        //	}
        //}

        [ObservableProperty]
        private ObservableCollection<TodoItem> _todoItems;

        //public event PropertyChangedEventHandler? PropertyChanged;
        //protected void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

        public TodoListViewModel()
        {
			this.TodoItems = new ObservableCollection<TodoItem>();

            //TODO: Initialise commands:
			//LoadDataCommand = new Command(LoadData);
   //         AddTodoCommand = new Command(AddTodo, CanAddTodo);
   //         DeleteTodoCommand = new Command<TodoItem>(DeleteTodo);
        }

		//      public ICommand LoadDataCommand { get; set; }
		//      public ICommand AddTodoCommand { get; set; }
		//public ICommand DeleteTodoCommand { get; set; }

		[RelayCommand]
		private void LoadData()
		{
			this.TodoItems = new ObservableCollection<TodoItem>(Data.TodoDb.GetTodoItems(10));
		}

		private bool CanAddTodo()
		{
			if (this.NewTodoTitle is null || this.NewTodoTitle.Length < 10)
				return false;
			else
				return true;
		}
        [RelayCommand(CanExecute = nameof(CanAddTodo))]
        private void AddTodo()
		{
			//TODO: add item to TodoItems, use NewTodoTitle as Title for the new item
			//TODO: clear the NewTodoTitle
			TodoItems.Insert(0, new TodoItem() 
			{ 
				Title = this.NewTodoTitle,
				IsCompleted = false
			});
			this.NewTodoTitle = string.Empty;
        }

        [RelayCommand]
        private void DeleteTodo(TodoItem item)
		{
			//TODO: remove item from TodoItems
			TodoItems.Remove(item);
		}
    }
}
