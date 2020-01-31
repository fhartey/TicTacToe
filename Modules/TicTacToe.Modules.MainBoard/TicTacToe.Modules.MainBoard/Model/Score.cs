using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TicTacToe.Modules.MainBoard.Model
{
    public class Score : INotifyPropertyChanged
    {

        public static ObservableCollection<Score> score = new ObservableCollection<Score>();

        public static void AddScore(int player, int computer, int draw)
        {
            score.Add(new Score()
            {
                PlayerWin = player,
                ComputerWin = computer,
                Draw = draw,
                Date = DateTime.Now

            });

        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Properties
        private int _playerwin;
        public int PlayerWin
        {
            get { return _playerwin; }
            set
            {
                _playerwin = value;
                OnPropertyChanged("PlayerWin");
            }
        }

        private int _computerwin;
        public int ComputerWin
        {
            get { return _computerwin; }
            set
            {
                _computerwin = value;
                OnPropertyChanged("ComputerWin");
            }
        }

        private int _draw;
        public int Draw
        {
            get { return _draw; }
            set
            {
                _draw = value;
                OnPropertyChanged("Draw");
            }
        }

        private DateTime? _date;
        public DateTime? Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }
        #endregion
        public override string ToString()
        {
            return String.Format("Players Point: {0}, Computers Point: {1}, Draw: {2}, Date: {3}",
                PlayerWin, ComputerWin, Draw, Date);
        }
    }
}
