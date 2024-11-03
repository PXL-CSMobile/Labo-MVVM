using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.UI.Models
{
    public class TodoItem
    {
        private string _title;
        private string _description;
        private bool _isCompleted;
        private DateTime _dueDate;

        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public bool IsCompleted { get => _isCompleted; set => _isCompleted = value; }
        public DateTime DueDate { get => _dueDate; set => _dueDate = value; }
    }
}
