using Prism.Commands;
using Prism.Mvvm;
using System;
using TicTacToe.Modules.MainBoard.Model;

namespace TicTacToe.Modules.MainBoard.ViewModels
{
    public class MainBoardViewModel : BindableBase
    {
        public DelegateCommand<string> PickedMoveCommand { get; private set; }
        public DelegateCommand RestartGameCommand { get; private set; }
        public DelegateCommand UpdateScoreCommand { get; private set; }

        public MainBoardViewModel()
        {
            // PickedMoveCommand: if CanUpdateScore is false then the user will be unable to touch the board
            PickedMoveCommand = new DelegateCommand<string>(UserMove).ObservesCanExecute(() => CanUpdateScore);
            RestartGameCommand = new DelegateCommand(RestartGame);
            UpdateScoreCommand = new DelegateCommand(AddScorePoint);
        }

        private void RestartGame()
        {
            CanUpdateScore = true;
            Board.RestartBoard();
            WinningGameMessage = null;
            UpdateDic();
        }
        /* UserMove takes a string parameter that is use in the MainBoardViewModel that is
        hardcoded in, to know which part of the board the user clicked on*/
        private void UserMove(string parameter)
        {

            if (Board.MainBoard[Convert.ToInt32(parameter)] != Board.Computer && Board.MainBoard[Convert.ToInt32(parameter)] != Board.Player)
            {

                Board.MainBoard[Convert.ToInt32(parameter)] = Board.Player;
                ComputerMovement.ComputerMove();
                CheckWin();
                UpdateDic();
            }
        }

        // Once the game is finished add the score up a point depending on who won the game
        public void AddScorePoint()
        {
            if (CanUpdateScore != true)
            {
                Score.AddScore(Board.PlayersPoint, Board.ComputersPoint, Board.DrawPoint);
            }
        }

        private void CheckWin()
        {
            if (Board.CheckGameOver() != false || Board.Draw() != false)
            {

                WinningGameMessage = Board.WinningMessage;
                CanUpdateScore = false;
            }
            else
            {
                CanUpdateScore = true;
            }

            UpdateScoreCommand.Execute();
        }

        public void UpdateDic()
        {
            Postion0Text = Board.MainBoard[0];
            Postion1Text = Board.MainBoard[1];
            Postion2Text = Board.MainBoard[2];
            Postion3Text = Board.MainBoard[3];
            Postion4Text = Board.MainBoard[4];
            Postion5Text = Board.MainBoard[5];
            Postion6Text = Board.MainBoard[6];
            Postion7Text = Board.MainBoard[7];
            Postion8Text = Board.MainBoard[8];
        }

        #region Properties

        private bool _canupdatescore = true;
        public bool CanUpdateScore
        {
            get { return _canupdatescore; }
            set { SetProperty(ref _canupdatescore, value); }
        }


        private string _winninggamemessage;
        public string WinningGameMessage
        {
            get { return _winninggamemessage; }
            set { SetProperty(ref _winninggamemessage, value); }
        }


        private string _position0text;
        public string Postion0Text
        {
            get { return _position0text; }
            set { SetProperty(ref _position0text, value); }
        }

        private string _position1text;
        public string Postion1Text
        {
            get { return _position1text; }
            set { SetProperty(ref _position1text, value); }
        }


        private string _position2text;
        public string Postion2Text
        {
            get { return _position2text; }
            set { SetProperty(ref _position2text, value); }
        }


        private string _position3text;
        public string Postion3Text
        {
            get { return _position3text; }
            set { SetProperty(ref _position3text, value); }
        }


        private string _position4text;
        public string Postion4Text
        {
            get { return _position4text; }
            set { SetProperty(ref _position4text, value); }
        }


        private string _position5text;
        public string Postion5Text
        {
            get { return _position5text; }
            set { SetProperty(ref _position5text, value); }
        }


        private string _position6text;
        public string Postion6Text
        {
            get { return _position6text; }
            set { SetProperty(ref _position6text, value); }
        }


        private string _position7text;
        public string Postion7Text
        {
            get { return _position7text; }
            set { SetProperty(ref _position7text, value); }
        }


        private string _position8text;
        public string Postion8Text
        {
            get { return _position8text; }
            set { SetProperty(ref _position8text, value); }
        }
        #endregion

    }
}
