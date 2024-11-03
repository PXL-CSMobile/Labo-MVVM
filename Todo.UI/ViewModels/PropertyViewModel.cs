using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Todo.UI.ViewModels
{
    public class GamesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private Game selectedGame;
        public Game SelectedGame
        {
            get => selectedGame; 
            set 
            { 
                selectedGame = value; 
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Game> AllGames { get; set; }

        public GamesViewModel()
        {
            this.AllGames = new ObservableCollection<Game>();
        }
    }


    public class Game : INotifyPropertyChanged
    {
        private string name;
        private int rating;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public int Rating
        {
            get => rating; 
            set 
            { 
                rating = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
