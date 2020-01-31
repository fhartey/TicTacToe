using System;

namespace TicTacToe.Modules.MainBoard.Model
{
    class ComputerMovement
    {

        public static int[,] BestMoves = new int[8, 3]{
        { 0, 4, 8 }, { 2, 4, 6 },
        { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
        { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }};


        public static void ComputerMove()
        {
            // will use this number if the computer needs to pick between two choices
            var ChoicePicked = new Random().Next(2);
            for (int i = 0; i < BestMoves.GetLength(0); i++)
            {

                // Computers offense moves to try and win the game first best option
                if (Board.MainBoard[BestMoves[i, 0]] == Board.Computer && Board.MainBoard[BestMoves[i, 1]] == Board.Computer && Board.MainBoard[BestMoves[i, 2]] == Board.Blank)
                {
                    Board.MainBoard[BestMoves[i, 2]] = Board.Computer;
                    Board.CheckTurn = Board.Player;
                    return;
                }

                else if (Board.MainBoard[BestMoves[i, 2]] == Board.Computer && Board.MainBoard[BestMoves[i, 0]] == Board.Computer && Board.MainBoard[BestMoves[i, 1]] == Board.Blank)
                {
                    Board.MainBoard[BestMoves[i, 1]] = Board.Computer;
                    Board.CheckTurn = Board.Player;
                    return;
                }
                else if (Board.MainBoard[BestMoves[i, 1]] == Board.Computer && Board.MainBoard[BestMoves[i, 2]] == Board.Computer && Board.MainBoard[BestMoves[i, 0]] == Board.Blank)
                {
                    Board.MainBoard[BestMoves[i, 0]] = Board.Computer;
                    Board.CheckTurn = Board.Player;
                    return;
                }
            }

            for (int i = 0; i < BestMoves.GetLength(0); i++)
            {
                // Computers defense moves to block the user second best option
                if (Board.MainBoard[BestMoves[i, 0]] == Board.Player && Board.MainBoard[BestMoves[i, 1]] == Board.Player && Board.MainBoard[BestMoves[i, 2]] == Board.Blank)
                {
                    Board.MainBoard[BestMoves[i, 2]] = Board.Computer;
                    Board.CheckTurn = Board.Player;
                    return;
                }

                else if (Board.MainBoard[BestMoves[i, 2]] == Board.Player && Board.MainBoard[BestMoves[i, 0]] == Board.Player && Board.MainBoard[BestMoves[i, 1]] == Board.Blank)
                {
                    Board.MainBoard[BestMoves[i, 1]] = Board.Computer;
                    Board.CheckTurn = Board.Player;
                    return;
                }
                else if (Board.MainBoard[BestMoves[i, 1]] == Board.Player && Board.MainBoard[BestMoves[i, 2]] == Board.Player && Board.MainBoard[BestMoves[i, 0]] == Board.Blank)
                {
                    Board.MainBoard[BestMoves[i, 0]] = Board.Computer;
                    Board.CheckTurn = Board.Player;
                    return;
                }
            }

            for (int i = 0; i < BestMoves.GetLength(0); i++)
            {
                // computers second defnese opition, third best move set
                if (Board.MainBoard[BestMoves[i, 0]] == Board.Player && Board.MainBoard[BestMoves[i, 1]] == Board.Blank && Board.MainBoard[BestMoves[i, 2]] == Board.Blank)
                {
                    if (ChoicePicked == 0)
                    {
                        Board.MainBoard[BestMoves[i, 1]] = Board.Computer;
                        Board.CheckTurn = Board.Computer;
                        return;
                    }
                    else
                    {
                        Board.MainBoard[BestMoves[i, 2]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                }

                else if (Board.MainBoard[BestMoves[i, 2]] == Board.Player && Board.MainBoard[BestMoves[i, 0]] == Board.Blank && Board.MainBoard[BestMoves[i, 1]] == Board.Blank)
                {
                    if (ChoicePicked == 0)
                    {
                        Board.MainBoard[BestMoves[i, 0]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                    else
                    {
                        Board.MainBoard[BestMoves[i, 1]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                }

                else if (Board.MainBoard[BestMoves[i, 1]] == Board.Player && Board.MainBoard[BestMoves[i, 2]] == Board.Blank && Board.MainBoard[BestMoves[i, 0]] == Board.Blank)
                {
                    if (ChoicePicked == 0)
                    {
                        Board.MainBoard[BestMoves[i, 2]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                    else
                    {
                        Board.MainBoard[BestMoves[i, 0]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                }
            }

            for (int i = 0; i < BestMoves.GetLength(0); i++)
            {
                // computer second offense opition fourth best moveset
                if (Board.MainBoard[BestMoves[i, 0]] == Board.Computer && Board.MainBoard[BestMoves[i, 1]] == Board.Blank && Board.MainBoard[BestMoves[i, 2]] == Board.Blank)
                {
                    if (ChoicePicked == 0)
                    {
                        Board.MainBoard[BestMoves[i, 1]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                    else
                    {
                        Board.MainBoard[BestMoves[i, 2]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                }

                else if (Board.MainBoard[BestMoves[i, 2]] == Board.Computer && Board.MainBoard[BestMoves[i, 0]] == Board.Blank && Board.MainBoard[BestMoves[i, 1]] == Board.Blank)
                {
                    if (ChoicePicked == 0)
                    {
                        Board.MainBoard[BestMoves[i, 0]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                    else
                    {
                        Board.MainBoard[BestMoves[i, 1]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                }

                else if (Board.MainBoard[BestMoves[i, 1]] == Board.Computer && Board.MainBoard[BestMoves[i, 2]] == Board.Blank && Board.MainBoard[BestMoves[i, 0]] == Board.Blank)
                {
                    if (ChoicePicked == 0)
                    {
                        Board.MainBoard[BestMoves[i, 2]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                    else
                    {
                        Board.MainBoard[BestMoves[i, 0]] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        return;
                    }
                }
            }

            // This will count for how far along the game it is. if it is not that far, we will just let the computer pick a random spot.
            if (Board.CheckTurn != Board.Player)
            {
                while (true)
                {
                    var RandomNumDepth = new Random().Next(9);
                    if (Board.MainBoard[RandomNumDepth] == Board.Blank)
                    {
                        Board.MainBoard[RandomNumDepth] = Board.Computer;
                        Board.CheckTurn = Board.Player;
                        break;
                    }
                    else if (Board.Draw() == true)
                    {
                        break;
                    }
                }
            }

        }


    }
}
