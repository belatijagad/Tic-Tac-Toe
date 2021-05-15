using System;

namespace Tic_Tac_Toe
{
    class Program
    {

         /*
                PROBLEM MASALAH EROR DALAM CODE !!
                    
                Ketika trigger atau kita melakukan eror angka diluar 1-9 kemudian kita memberi input baru yang kosong di kotaknya maka akan eror index out of range

                        FIX AYO !! 
          */

        /*  Catatan :
            Kenapa harus membuat function "Komputer" & "Player" ?
            "Terus terang saya juga lupa kenapa. Kalau tidak salah supaya mengurangi penulisan
            kode (mungkin)" - Qois */

        // Function / Method "Komputer"
        static string[] Komputer(string[] Kotak, string playerSymbol, string computerSymbol, int kotakTerisi, string pengenal)
        {
            // Ini adalah variabel
            int botInput;

            // Mengubah pengenal menjadi "K" singkatan dari Komputer
            pengenal = "K";

            /* CATATAN :
             * Kepada bagian AI nanti memanggil Methodnya disini. Untuk sekarang belum ada cara menentukan
             * siapa yang jalan duluan, jadi mungkin harus melakukan sesuatu terhadap hal itu.
             * Terserah mau menggunakan variabel atau tidak, tapi method "Game.NilaiKotak" butuh value berupa int
             * (Cek parameternya terlebih dahulu)
             *
             * CONTOH :
             * botInput = AI.ComputerMoveSecond(Kotak, kotakTerisi, computerSymbol, playerSymbol);
             */

            // Ini sangat hanya sementara
            Console.SetCursorPosition((Console.WindowWidth - 21) / 2, ((Console.WindowHeight) / 2) + 10);
            Console.Write("Masukkan bot Input : ");
            botInput = Convert.ToInt32(Console.ReadLine());

            // Ini sangat diperlukan
            Kotak = Game.NilaiKotak(Kotak, (botInput - 1), pengenal);

            return Kotak;
        }


        // Function / Method "Player"
        public static string[] Player(string[] Kotak, string pengenal)
        {
            // Ini variabel
            int userInput;

            // Mengubah pengenal menjadi "P" singkatan dari Player
            pengenal = "P";

            Console.SetCursorPosition((Console.WindowWidth - 23) / 2, ((Console.WindowHeight) / 2)+5);
            Console.Write("Masukkan user Input : ");

            // Menyaring bila input bukanlah berupa int
            if (int.TryParse(Console.ReadLine(), out userInput)) {
                Console.SetCursorPosition((Console.WindowWidth - 23) / 2, ((Console.WindowHeight) / 2) + 5);
                Console.Write("Masukkan user Input :         ");
                Kotak = Game.NilaiKotak(Kotak, (userInput - 1) * 1, pengenal);
            } else {
                Console.SetCursorPosition((Console.WindowWidth - 23) / 2, ((Console.WindowHeight) / 2) + 5);
                Console.Write("Masukkan user Input :         ");
                Console.SetCursorPosition((Console.WindowWidth - 18) / 2, ((Console.WindowHeight) / 2)+7);
                Console.WriteLine("Harus berupa angka");
                Player(Kotak, pengenal);
            }

            return Kotak;
        }


        static void Main(string[] args)
        {
            //UI -- menetapkan ukuran window
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(90, 30);
            Console.SetWindowSize(90, 30);

            // Variabel yang merepresentatifkan papan permainan
            String[] Kotak = {"#","#","#","#","#","#","#","#","#"};
            
            // Randomizer dan variabelnya
            var rng = new Random();
            int nomorAcak = rng.Next(1, 3);

            /*
              Membuat variabel apa game masih layak untuk dilanjutkan atau tidak
              Jika salah satu pihak menang atau semua kotak terisi, nantinya nilai
              apaGameBerjalan = false
            */
            bool apaGameBerjalan = true;
            
            //Panduan bagi program untuk parameter di method AI nanti
            string playerSymbol = "O";
            string computerSymbol = "X";

            /*
             * Variabel untuk memberitahu jumlah kotak yang sudah diisi
             * Agar mempermudah penentuan gerakan AI
             */
            int kotakTerisi = 0;

            /*
                Variabel sebagai pengenal, fungsi kurang lebih seperti tanda nama
                yaitu untuk mengetahui anda siapa. Dalam hal ini untuk mengetahui apakah
                anda manusia / bot. Kenapa harus begini ?. jawabannya adalah saya tidak tahu
                cara lain, kalau punya solusi lain, kontak saya.
            */
            string pengenal = "N"; // "N" singkatan dari null

            // Loop permainannya
            while(apaGameBerjalan) {

                // UI
                UI.Board(Kotak);

                // Apabila bot jalan duluan
                if (nomorAcak == 1)
                {
                    // Memanggil function Komputer
                    Kotak = Komputer(Kotak, playerSymbol, computerSymbol, kotakTerisi, pengenal);

                    // UI
                    UI.Board(Kotak);

                    /* Catatan :
                     * "Bagian Menang / kalah mungkin kurang efisien. Tetapi ini 'get the job done'.
                     * Suatu saat mungkin akan dibuat kode jauh lebih efisien." - Qois */

                    // Menang / Kalah
                    apaGameBerjalan = Game.MenangKalah(apaGameBerjalan, Kotak, computerSymbol);
                    if (apaGameBerjalan == false) {
                        Console.SetCursorPosition((Console.WindowWidth - 17) / 2, ((Console.WindowHeight) / 2) + 10);
                        Console.WriteLine("Permainan selesai");
                        Console.SetCursorPosition((Console.WindowWidth - 28) / 2, ((Console.WindowHeight) / 2) + 11);
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();

                        // Reset permainan
                        Main(null);
                        return;
                    }

                    //Memberitahu program kalau kotak yang terisi + 1
                    kotakTerisi++;

                    // Memanggil function Player, benar sama sekali tidak hubungan dengan AI
                    Kotak = Player(Kotak, pengenal);

                    // UI
                    UI.Board(Kotak);

                    // Menang / Kalah
                    apaGameBerjalan = Game.MenangKalah(apaGameBerjalan, Kotak, playerSymbol);
                    if (apaGameBerjalan == false) {
                        Console.SetCursorPosition((Console.WindowWidth - 17) / 2, ((Console.WindowHeight) / 2) + 10);
                        Console.WriteLine("Permainan selesai");
                        Console.SetCursorPosition((Console.WindowWidth - 28) / 2, ((Console.WindowHeight) / 2) + 11);
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();

                        Main(null);
                        return;
                    }

                    //Memberitahu program kalau kotak yang terisi + 1
                    kotakTerisi++;

                }

                // Apabila bot jalan kedua setelah pemain jalan
                else if (nomorAcak == 2)
                {
                    // Memanggil function Player, benar sama sekali tidak hubungan dengan AI
                    Kotak = Player(Kotak, pengenal);

                    // UI
                    UI.Board(Kotak);

                    // Menang / Kalah
                    apaGameBerjalan = Game.MenangKalah(apaGameBerjalan, Kotak, playerSymbol);
                    if (apaGameBerjalan == false) {
                        Console.SetCursorPosition((Console.WindowWidth - 17) / 2, ((Console.WindowHeight) / 2) + 10);
                        Console.WriteLine("Permainan selesai");
                        Console.SetCursorPosition((Console.WindowWidth - 28) / 2, ((Console.WindowHeight) / 2) + 11);
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();

                        Main(null);
                        return;
                    }

                    //Memberitahu program kalau kotak yang terisi + 1
                    kotakTerisi++;

                    // Memanggil function Komputer, tidak ada hubungannya dengan AI (mungkin)
                    Kotak = Komputer(Kotak, playerSymbol, computerSymbol, kotakTerisi, pengenal);

                    // UI
                    UI.Board(Kotak);

                    // Menang / Kalah
                    apaGameBerjalan = Game.MenangKalah(apaGameBerjalan, Kotak, computerSymbol);
                    if (apaGameBerjalan == false) {
                        Console.SetCursorPosition((Console.WindowWidth - 17) / 2, ((Console.WindowHeight) / 2) + 10);
                        Console.WriteLine("Permainan selesai");
                        Console.SetCursorPosition((Console.WindowWidth - 28) / 2, ((Console.WindowHeight) / 2) + 11);
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();

                        Main(null);
                        return;
                    }

                    //Memberitahu program kalau kotak yang terisi + 1
                    kotakTerisi++;

                }
            }

            //Mereset jumlah kotak terisi setelah sesi permainan selesai
            // kotakTerisi = 0;
        }
    }
}
