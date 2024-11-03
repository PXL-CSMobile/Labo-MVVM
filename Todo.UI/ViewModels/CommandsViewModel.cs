using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Todo.UI.ViewModels
{
    public class CommandsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand ExampleCommand { get; private set; }
        public ICommand ExampleWithParamCommand { get; private set; }

        public CommandsViewModel()
        {
            ExampleCommand = new Command(ExampleMethod, CanExecuteExample);
            ExampleWithParamCommand = new Command<object>(ExampleMethodWithParam);
        }


        private bool CanExecuteExample()
        {
            return true;
        }
        private void ExampleMethod()
        {
            //Do some stuff
        }
        private void ExampleMethodWithParam(object value)
        {
            //Do some stuff with value
        }
    }
}
