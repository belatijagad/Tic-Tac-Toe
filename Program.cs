using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menyatakan class dan beberapa variabel yang dibutuhkan
            Game game = new Game();
            String[] Kotak = {"#","#","#","#","#","#","#","#","#"};
            int botInput;
            int userInput;

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


            // Loop permainannya
            while(apaGameBerjalan) {

                // Dibagian ini berfungsi untuk mencari bot Input
                // Bagian ini bisa diganti dengan bagaimanapun
                // asalkan akan mengupdate variabel "botInput"
                // variable "botInput" harus antara 1 - 9
                Console.Write("Masukkan bot Input : ");
                botInput = Convert.ToInt32(Console.ReadLine());

                //Memberitahu program kalau kotak yang terisi + 1
                kotakTerisi++;

                // Jangan diganti !!
                // Untuk mencari tahu kenapa nanti akan dikali -1
                // Liat comment di file "Game.cs" bagian method
                // 'IdentifikasiPlayer'
                Kotak = game.NilaiKotak(Kotak, (botInput - 1) * -1);

                // Bagian ini befungsi untuk memprint permainannya
                // Bagian ini bisa diganti sebebas mungkin
                // untuk isi per kotaknya gunakan array "Kotak"
                // Range arraynya dari 0 - 8
                for (int i = 0; i < 9; i++) {
                    Console.WriteLine(Kotak[i]);
                }

                // Bagian ini hanya untuk user input
                Console.Write("Masukkan user Input : ");
                userInput = Convert.ToInt32(Console.ReadLine());

                //Memberitahu program kalau kotak yang terisi + 1
                kotakTerisi++;

                // Jangan diganti !!
                Kotak = game.NilaiKotak(Kotak, (userInput - 1) * 1);

                // Clear console
                Console.Clear();

            }

            //Mereset jumlah kotak terisi setelah sesi permainan selesai
            kotakTerisi = 0;
        }
    }
}
