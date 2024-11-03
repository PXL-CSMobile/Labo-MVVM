using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Todo.UI.Models;

namespace Todo.UI.ViewModels
{
    public class TodoListViewModel: INotifyPropertyChanged
    {
		private string _newTodoTitle;
		public string NewTodoTitle
		{
			get 
			{ 
				return _newTodoTitle; 
			}
			set 
			{ 
				_newTodoTitle = value; 
			}
		}

		public ObservableCollection<TodoItem> TodoItems { get; set; } 

        public event PropertyChangedEventHandler? PropertyChanged;

        public TodoListViewModel()
        {
			this.TodoItems = new ObservableCollection<TodoItem>();

            //TODO: Initialise commands:
			LoadDataCommand = new Command(LoadData);
            AddTodoCommand = new Command(AddTodo);
            DeleteTodoCommand = new Command<TodoItem>(DeleteTodo);
        }

        public ICommand LoadDataCommand { get; set; }
        public ICommand AddTodoCommand { get; set; }
		public ICommand DeleteTodoCommand { get; set; }

		private void LoadData()
		{
			this.TodoItems = new ObservableCollection<TodoItem>(Data.TodoDb.GetTodoItems(15));
		}

		private void AddTodo()
		{
			//TODO: add item to TodoItems, use NewTodoTitle as Title for the new item
			//TODO: clear the NewTodoTitle
		}

		private void DeleteTodo(TodoItem item)
		{
			//TODO: remove item from TodoItems
		}
    }
}
