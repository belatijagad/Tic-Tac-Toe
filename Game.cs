using System;

namespace Tic_Tac_Toe
{
    class Game
    {
        /* TODO :
         * - Menentukan apabila permainan
         *   dimenangkan salah satu pihak */

        public string IdentifikasiPlayer(int input)
        {
            string x;

            // Menentukan yang memberikan input
            // Apakah player atau bot
            // ciri - ciri bot adalah
            // bila inputnya rangenya
            // -9 < x < -1
            if (input > 0) {
                x = "O";
            } else {
                x = "X";
            }

            return x;
        }


        public string[] NilaiKotak(string[] kotak, int input) {

            // Nilai yang diterima
            if (input > 8 || input < -8) {
                Console.WriteLine("Invalid Input");
                System.Environment.Exit(1);
            }

            string gantiNilai = IdentifikasiPlayer(input);

            // Bila inputnya dari bot, maka nanti inputnya
            // akan bernilai negatif, oleh karena itu harus
            // dikembalikan kembali ke bentuk positif
            if (gantiNilai == "X") {
                input *= -1;
            }

            // Bila kotak sudah tersisi
            if (kotak[input] != "#") {
                Console.WriteLine("Kotak sudah terisi");
                System.Environment.Exit(1);
            }

            // Mengganti nilai
            kotak[input] = gantiNilai;

            return kotak;
        }
    }
}
