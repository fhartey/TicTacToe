using Prism.Mvvm;
using Prism.Regions;
using System.Collections.ObjectModel;
using TicTacToe.Modules.MainBoard.Model;

namespace TicTacToe.Modules.MainBoard.ViewModels
{
    public class ScoreBoardViewModel : BindableBase, INavigationAware
    {

        public ScoreBoardViewModel()
        {
            Scores = Score.score;

        }
        private void TallyScores()
        {
            Wins = 0;
            Losses = 0;
            Draws = 0;
            for (int i = 0; i < Scores.Count; i++)
            {
                Wins = Wins + Scores[i].PlayerWin;
                Losses = Losses + Scores[i].ComputerWin;
                Draws = Draws + Scores[i].Draw;
            }
        }
        // Using OnNavigatedTo, so when the user switches views. the Messages will be updated to the current scores
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            TallyScores();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
        #region Properties
        private ObservableCollection<Score> _score;
        public ObservableCollection<Score> Scores
        {
            get { return _score; }
            set
            {
                SetProperty(ref _score, value);
            }
        }

        private int _wins;
        public int Wins
        {
            get { return _wins; }
            set
            {
                SetProperty(ref _wins, value);

            }
        }

        private int _losses;
        public int Losses
        {
            get { return _losses; }
            set
            {
                SetProperty(ref _losses, value);

            }
        }


        private int _draws;
        public int Draws
        {
            get { return _draws; }
            set
            {
                SetProperty(ref _draws, value);
            }
        }
        #endregion
    }
}
