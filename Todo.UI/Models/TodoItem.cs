using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Todo.UI.Models
{
    public partial class TodoItem : ObservableObject
    {
        [ObservableProperty]
        private string _title;
        [ObservableProperty]
        private string _description;
        [ObservableProperty]
        private bool _isCompleted;
        [ObservableProperty]
        private DateTime _dueDate;

    }
}
