using Prism.Mvvm;
using System.Collections.Generic;


namespace TicTacToe.Modules.MainBoard.Model
{
    public class Board : BindableBase
    {
        // 2D array to store all possible winning moves,
        public static int[,] WinningMoves = new int[8, 3] {
        { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
        { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
        { 0, 4, 8 }, { 2, 4, 6 }
  };
        public static readonly string Blank = " ";
        public static readonly string Player = "X";
        public static readonly string Computer = "O";

        public static Dictionary<int, string> MainBoard = new Dictionary<int, string>() {
            {0," "},
            {1," "},
            {2," "},
            {3," "},
            {4," "},
            {5," "},
            {6," "},
            {7," "},
            {8," "},
        };

        public static void RestartBoard()
        {
            ComputersPoint = 0;
            PlayersPoint = 0;
            DrawPoint = 0;
            for (int i = 0; i < MainBoard.Count; i++)
            {
                MainBoard[i] = Blank;
            }
        }
        public static bool CheckGameOver()
        {

            for (int i = 0; i < WinningMoves.GetLength(0); i++)
            {
                if (MainBoard[WinningMoves[i, 0]] == Player && MainBoard[WinningMoves[i, 1]] == Player && MainBoard[WinningMoves[i, 2]] == Player)
                {
                    PlayersPoint = 1;
                    WinningMessage = "You have won the game";
                    return true;
                }
                else if (MainBoard[WinningMoves[i, 0]] == Computer && MainBoard[WinningMoves[i, 1]] == Computer && MainBoard[WinningMoves[i, 2]] == Computer)
                {
                    ComputersPoint = 1;
                    WinningMessage = "The computer has won the game";
                    return true;
                }
            }

            return false;
        }

        public static bool Draw()
        {
            int DrawCheck = 0;
            for (int i = 0; i < 9; i++)
            {
                if (MainBoard[i] != Blank)
                {
                    DrawCheck++;
                    if (DrawCheck == 9)
                    {
                        DrawPoint = 1;
                        WinningMessage = "This Game ended in a draw";
                        return true;
                    }
                }
            }
            return false;
        }

        #region Properties
        private static string _checkturn;
        public static string CheckTurn
        {
            get { return _checkturn; }
            set { _checkturn = value; }
        }

        private static int _playerspoint;
        public static int PlayersPoint
        {
            get { return _playerspoint; }
            set { _playerspoint = value; }
        }

        private static int _computersPoint;
        public static int ComputersPoint
        {
            get { return _computersPoint; }
            set { _computersPoint = value; }
        }

        private static int _drawpoint;
        public static int DrawPoint
        {
            get { return _drawpoint; }
            set { _drawpoint = value; }
        }

        private static string _winningmessage;
        public static string WinningMessage
        {
            get { return _winningmessage; }
            set { _winningmessage = value; }
        }
        #endregion
    }
}
