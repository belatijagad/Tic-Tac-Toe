using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class AI
    {
        #region Pemain_Jalan_Duluan_(Abel)
        public static int ComputerMoveSecond(string[] gameBoard, int squaresFilled, string computerSymbol, string playerSymbol)
        {
            switch (squaresFilled)
            {
                case 1:
                    if (IsBlank(gameBoard[4], computerSymbol, playerSymbol))
                    {
                        return 4;
                    }
                    return 0;
                case 3:
                    for (int i = 0; i < 3; i++)
                    {
                        if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 1], gameBoard[3 * i + 2], computerSymbol) && IsBlank(gameBoard[3 * i + 2], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 2);
                        }
                        else if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 2], gameBoard[3 * i + 1], computerSymbol) && IsBlank(gameBoard[3 * i + 1], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 1);
                        }
                        else if (DenyWin(gameBoard[3 * i + 1], gameBoard[3 * i + 2], gameBoard[3 * i], computerSymbol) && IsBlank(gameBoard[3 * i], computerSymbol, playerSymbol))
                        {
                            return (3 * i);
                        }

                        else if (DenyWin(gameBoard[i], gameBoard[i + 3], gameBoard[i + 6], computerSymbol) && IsBlank(gameBoard[i + 6], computerSymbol, playerSymbol))
                        {
                            return (i + 6);
                        }
                        else if (DenyWin(gameBoard[i], gameBoard[i + 6], gameBoard[i + 3], computerSymbol) && IsBlank(gameBoard[i + 3], computerSymbol, playerSymbol))
                        {
                            return (i + 3);
                        }
                        else if (DenyWin(gameBoard[i + 3], gameBoard[i + 6], gameBoard[i], computerSymbol) && IsBlank(gameBoard[i], computerSymbol, playerSymbol))
                        {
                            return i;
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 1], gameBoard[3 * i + 2], playerSymbol) && IsBlank(gameBoard[3 * i + 2], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 2);
                        }
                        else if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 2], gameBoard[3 * i + 1], playerSymbol) && IsBlank(gameBoard[3 * i + 1], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 1);
                        }
                        else if (DenyWin(gameBoard[3 * i + 1], gameBoard[3 * i + 2], gameBoard[3 * i], playerSymbol) && IsBlank(gameBoard[3 * i], computerSymbol, playerSymbol))
                        {
                            return (3 * i);
                        }

                        else if (DenyWin(gameBoard[i], gameBoard[i + 3], gameBoard[i + 6], playerSymbol) && IsBlank(gameBoard[i + 6], computerSymbol, playerSymbol))
                        {
                            return (i + 6);
                        }
                        else if (DenyWin(gameBoard[i], gameBoard[i + 6], gameBoard[i + 3], playerSymbol) && IsBlank(gameBoard[i + 3], computerSymbol, playerSymbol))
                        {
                            return (i + 3);
                        }
                        else if (DenyWin(gameBoard[i + 3], gameBoard[i + 6], gameBoard[i], playerSymbol) && IsBlank(gameBoard[i], computerSymbol, playerSymbol))
                        {
                            return i;
                        }
                    }

                    //Check top right to bottom left diagonal for any mates
                    if (DenyWin(gameBoard[2], gameBoard[4], gameBoard[6], playerSymbol) && IsBlank(gameBoard[6], computerSymbol, playerSymbol))
                    {
                        return 6;
                    }
                    else if (DenyWin(gameBoard[2], gameBoard[6], gameBoard[4], playerSymbol) && IsBlank(gameBoard[4], computerSymbol, playerSymbol))
                    {
                        return 4;
                    }
                    else if (DenyWin(gameBoard[4], gameBoard[6], gameBoard[2], playerSymbol) && IsBlank(gameBoard[2], computerSymbol, playerSymbol))
                    {
                        return 2;
                    }

                    //Check top left to bottom right diagonals for any mates
                    else if (DenyWin(gameBoard[0], gameBoard[4], gameBoard[8], playerSymbol) && IsBlank(gameBoard[8], computerSymbol, playerSymbol))
                    {
                        return 6;
                    }
                    else if (DenyWin(gameBoard[0], gameBoard[8], gameBoard[4], playerSymbol) && IsBlank(gameBoard[4], computerSymbol, playerSymbol))
                    {
                        return 4;
                    }
                    else if (DenyWin(gameBoard[4], gameBoard[8], gameBoard[0], playerSymbol) && IsBlank(gameBoard[0], computerSymbol, playerSymbol))
                    {
                        return 0;
                    }

                    //Do any move
                    for (int i = 0; i < 7; i++)
                    {
                        if (OnlyMove(gameBoard, i) && IsBlank(gameBoard[i], computerSymbol, playerSymbol))
                        {
                            return i;
                        }
                    }
                    return 0;
                case 5:
                    for (int i = 0; i < 3; i++)
                    {
                        if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 1], gameBoard[3 * i + 2], computerSymbol) && IsBlank(gameBoard[3 * i + 2], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 2);
                        }
                        else if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 2], gameBoard[3 * i + 1], computerSymbol) && IsBlank(gameBoard[3 * i + 1], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 1);
                        }
                        else if (DenyWin(gameBoard[3 * i + 1], gameBoard[3 * i + 2], gameBoard[3 * i], computerSymbol) && IsBlank(gameBoard[3 * i], computerSymbol, playerSymbol))
                        {
                            return (3 * i);
                        }

                        else if (DenyWin(gameBoard[i], gameBoard[i + 3], gameBoard[i + 6], computerSymbol) && IsBlank(gameBoard[i + 6], computerSymbol, playerSymbol))
                        {
                            return (i + 6);
                        }
                        else if (DenyWin(gameBoard[i], gameBoard[i + 6], gameBoard[i + 3], computerSymbol) && IsBlank(gameBoard[i + 3], computerSymbol, playerSymbol))
                        {
                            return (i + 3);
                        }
                        else if (DenyWin(gameBoard[i + 3], gameBoard[i + 6], gameBoard[i], computerSymbol) && IsBlank(gameBoard[i], computerSymbol, playerSymbol))
                        {
                            return i;
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 1], gameBoard[3 * i + 2], playerSymbol) && IsBlank(gameBoard[3 * i + 2], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 2);
                        }
                        else if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 2], gameBoard[3 * i + 1], playerSymbol) && IsBlank(gameBoard[3 * i + 1], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 1);
                        }
                        else if (DenyWin(gameBoard[3 * i + 1], gameBoard[3 * i + 2], gameBoard[3 * i], playerSymbol) && IsBlank(gameBoard[3 * i], computerSymbol, playerSymbol))
                        {
                            return (3 * i);
                        }

                        else if (DenyWin(gameBoard[i], gameBoard[i + 3], gameBoard[i + 6], playerSymbol) && IsBlank(gameBoard[i + 6], computerSymbol, playerSymbol))
                        {
                            return (i + 6);
                        }
                        else if (DenyWin(gameBoard[i], gameBoard[i + 6], gameBoard[i + 3], playerSymbol) && IsBlank(gameBoard[i + 3], computerSymbol, playerSymbol))
                        {
                            return (i + 3);
                        }
                        else if (DenyWin(gameBoard[i + 3], gameBoard[i + 6], gameBoard[i], playerSymbol) && IsBlank(gameBoard[i], computerSymbol, playerSymbol))
                        {
                            return i;
                        }
                    }

                    //Check top right to bottom left diagonal for any mates
                    if (DenyWin(gameBoard[2], gameBoard[4], gameBoard[6], playerSymbol) && IsBlank(gameBoard[6], computerSymbol, playerSymbol))
                    {
                        return 6;
                    }
                    else if (DenyWin(gameBoard[2], gameBoard[6], gameBoard[4], playerSymbol) && IsBlank(gameBoard[4], computerSymbol, playerSymbol))
                    {
                        return 4;
                    }
                    else if (DenyWin(gameBoard[4], gameBoard[6], gameBoard[2], playerSymbol) && IsBlank(gameBoard[2], computerSymbol, playerSymbol))
                    {
                        return 2;
                    }

                    //Check top left to bottom right diagonals for any mates
                    else if (DenyWin(gameBoard[0], gameBoard[4], gameBoard[8], playerSymbol) && IsBlank(gameBoard[8], computerSymbol, playerSymbol))
                    {
                        return 6;
                    }
                    else if (DenyWin(gameBoard[0], gameBoard[8], gameBoard[4], playerSymbol) && IsBlank(gameBoard[4], computerSymbol, playerSymbol))
                    {
                        return 4;
                    }
                    else if (DenyWin(gameBoard[4], gameBoard[8], gameBoard[0], playerSymbol) && IsBlank(gameBoard[0], computerSymbol, playerSymbol))
                    {
                        return 0;
                    }

                    //Do any move
                    for (int i = 0; i < 7; i++)
                    {
                        if (OnlyMove(gameBoard, i) && IsBlank(gameBoard[i], computerSymbol, playerSymbol))
                        {
                            return i;
                        }
                    }
                    return 0;
                case 7:
                    for (int i = 0; i < 3; i++)
                    {
                        if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 1], gameBoard[3 * i + 2], computerSymbol) && IsBlank(gameBoard[3 * i + 2], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 2);
                        }
                        else if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 2], gameBoard[3 * i + 1], computerSymbol) && IsBlank(gameBoard[3 * i + 1], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 1);
                        }
                        else if (DenyWin(gameBoard[3 * i + 1], gameBoard[3 * i + 2], gameBoard[3 * i], computerSymbol) && IsBlank(gameBoard[3 * i], computerSymbol, playerSymbol))
                        {
                            return (3 * i);
                        }

                        else if (DenyWin(gameBoard[i], gameBoard[i + 3], gameBoard[i + 6], computerSymbol) && IsBlank(gameBoard[i + 6], computerSymbol, playerSymbol))
                        {
                            return (i + 6);
                        }
                        else if (DenyWin(gameBoard[i], gameBoard[i + 6], gameBoard[i + 3], computerSymbol) && IsBlank(gameBoard[i + 3], computerSymbol, playerSymbol))
                        {
                            return (i + 3);
                        }
                        else if (DenyWin(gameBoard[i + 3], gameBoard[i + 6], gameBoard[i], computerSymbol) && IsBlank(gameBoard[i], computerSymbol, playerSymbol))
                        {
                            return i;
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 1], gameBoard[3 * i + 2], playerSymbol) && IsBlank(gameBoard[3 * i + 2], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 2);
                        }
                        else if (DenyWin(gameBoard[3 * i], gameBoard[3 * i + 2], gameBoard[3 * i + 1], playerSymbol) && IsBlank(gameBoard[3 * i + 1], computerSymbol, playerSymbol))
                        {
                            return (3 * i + 1);
                        }
                        else if (DenyWin(gameBoard[3 * i + 1], gameBoard[3 * i + 2], gameBoard[3 * i], playerSymbol) && IsBlank(gameBoard[3 * i], computerSymbol, playerSymbol))
                        {
                            return (3 * i);
                        }

                        else if (DenyWin(gameBoard[i], gameBoard[i + 3], gameBoard[i + 6], playerSymbol) && IsBlank(gameBoard[i + 6], computerSymbol, playerSymbol))
                        {
                            return (i + 6);
                        }
                        else if (DenyWin(gameBoard[i], gameBoard[i + 6], gameBoard[i + 3], playerSymbol) && IsBlank(gameBoard[i + 3], computerSymbol, playerSymbol))
                        {
                            return (i + 3);
                        }
                        else if (DenyWin(gameBoard[i + 3], gameBoard[i + 6], gameBoard[i], playerSymbol) && IsBlank(gameBoard[i], computerSymbol, playerSymbol))
                        {
                            return i;
                        }
                    }

                    //Check top right to bottom left diagonal for any mates
                    if (DenyWin(gameBoard[2], gameBoard[4], gameBoard[6], playerSymbol) && IsBlank(gameBoard[6], computerSymbol, playerSymbol))
                    {
                        return 6;
                    }
                    else if (DenyWin(gameBoard[2], gameBoard[6], gameBoard[4], playerSymbol) && IsBlank(gameBoard[4], computerSymbol, playerSymbol))
                    {
                        return 4;
                    }
                    else if (DenyWin(gameBoard[4], gameBoard[6], gameBoard[2], playerSymbol) && IsBlank(gameBoard[2], computerSymbol, playerSymbol))
                    {
                        return 2;
                    }

                    //Check top left to bottom right diagonals for any mates
                    else if (DenyWin(gameBoard[0], gameBoard[4], gameBoard[8], playerSymbol) && IsBlank(gameBoard[8], computerSymbol, playerSymbol))
                    {
                        return 6;
                    }
                    else if (DenyWin(gameBoard[0], gameBoard[8], gameBoard[4], playerSymbol) && IsBlank(gameBoard[4], computerSymbol, playerSymbol))
                    {
                        return 4;
                    }
                    else if (DenyWin(gameBoard[4], gameBoard[8], gameBoard[0], playerSymbol) && IsBlank(gameBoard[0], computerSymbol, playerSymbol))
                    {
                        return 0;
                    }

                    //Do any move
                    for (int i = 0; i < 7; i++)
                    {
                        if (OnlyMove(gameBoard, i) && IsBlank(gameBoard[i], computerSymbol, playerSymbol))
                        {
                            return i;
                        }
                    }
                    return 0;
                default:
                    return 0;
            }
        }
        static bool IsBlank(string firstTile, string computerSymbol, string playerSymbol)
        {
            if (firstTile != playerSymbol && firstTile != computerSymbol)
            {
                return true;
            }
            return false;
        }
        static bool IsPlayer(string playerTile, string playerSymbol)
        {
            if (playerTile == playerSymbol)
            {
                return true;
            }
            return false;
        }
        static bool WinningMove(string firstTile, string secondTile, string emptyTile, string computerSymbol)
        {
            if (firstTile == secondTile && firstTile == computerSymbol && emptyTile == "#")
            {
                return true;
            }
            return false;
        }
        static bool OnlyMove(string[] gameBoard, int computerMove)
        {
            if (gameBoard[computerMove] == "#")
            {
                return true;
            }
            return false;
        }
        static bool DenyWin(string firstTile, string secondTile, string chosenTile, string playerSymbol)
        {
            if (firstTile == secondTile && firstTile == playerSymbol && chosenTile == "#")
            {
                return true;
            }
            return false;
        }
        #endregion Pemain_Jalan_Duluan_(Abel)

        #region Bot_Jalan_Duluan_(Aidan)
        #endregion Bot_Jalan_Duluan_(Aidan)
    }
}