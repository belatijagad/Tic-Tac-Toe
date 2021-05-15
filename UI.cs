using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class UI
    {
        /*
         1. dipslay board
         2. score
         
         */

        static public void Board(string[] kotak)
        {
            Console.Clear();
            

            Console.SetCursorPosition((Console.WindowWidth - 15) / 2, ((Console.WindowHeight) / 2)-5);
            Console.WriteLine("+=============+");
            Console.SetCursorPosition((Console.WindowWidth - 15) / 2, ((Console.WindowHeight) / 2)-4);
            Console.WriteLine("| {0} || {1} || {2} |", kotak[0], kotak[1], kotak[2]);
            Console.SetCursorPosition((Console.WindowWidth - 15) / 2, ((Console.WindowHeight) / 2)-3);
            Console.WriteLine("+=============+");
            Console.SetCursorPosition((Console.WindowWidth - 15) / 2, ((Console.WindowHeight) / 2)-2);
            Console.WriteLine("| {0} || {1} || {2} |", kotak[3], kotak[4], kotak[5]);
            Console.SetCursorPosition((Console.WindowWidth - 15) / 2, ((Console.WindowHeight) / 2)-1);
            Console.WriteLine("+=============+");
            Console.SetCursorPosition((Console.WindowWidth - 15) / 2, (Console.WindowHeight) / 2);
            Console.WriteLine("| {0} || {1} || {2} |", kotak[6], kotak[7], kotak[8]);
            Console.SetCursorPosition((Console.WindowWidth - 15) / 2, ((Console.WindowHeight) / 2)+1);
            Console.WriteLine("+=============+");
            Console.SetCursorPosition((Console.WindowWidth - 23) / 2, ((Console.WindowHeight) / 2) + 5);
            Console.Write("Masukkan user Input : ");
        }

        static public int UserInput()
        {
            return 0;
        }

    }
}
