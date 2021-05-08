using System;

namespace Tic_Tac_Toe
{
    class Game
    {
        // Menyaring Input
        static void MenyaringInput(int input, string[] Kotak, string pengenal) {

            // Inputnya diluar jangka
            if ((input > 8 || input < 0) && (pengenal == "P")) {
                Console.WriteLine(input);
                Console.WriteLine("Pilihan hanya antara 1 - 9");
                Program.Player(Kotak, pengenal);
            }

            // Bagian Kotaknya sudah terisi
            if (Kotak[input] != "#") {
                Console.WriteLine("Sudah terisi, pilih yang lain");
                Program.Player(Kotak, pengenal);
            }

        }


        // Mengidentifikasi Player
        static string IdentifikasiPlayer(int input, string pengenal)
        {
            string temp = "#";

            // P singkatan untuk Player
            if (pengenal == "P") {
                temp = "O";

            // K singkatan untuk Komputer
            } else if (pengenal == "K") {
                temp = "X";
            }

            return temp;
        }


        // Yang akan memodifikasi Papan permainan
        public static string[] NilaiKotak(string[] kotak, int input, string pengenal) {

            string gantiNilai = IdentifikasiPlayer(input, pengenal);

            MenyaringInput(input, kotak, pengenal);

            // Mengganti nilai
            kotak[input] = gantiNilai;

            return kotak;
        }


        // Bagian menentukan Kemenangan atau Seri
        public static bool MenangKalah(bool status, string[] kotak, string simbol) {
            /* Catatan :
             * "Walaupun terlihat acak - acakan, tetapi ini mungkin adalah cara paling efficent,
             * dan saya menggunakan if statement" -Qois */

            // Melihat apakah ada 3 kotak yang memiliki simbol yang sama
            // HORIZONTAL / Kesamping
            if (kotak[1] == simbol && kotak[0] == kotak[1] && kotak[2] == kotak[1]) {
                status = false;
            } else if (kotak[4] == simbol && kotak[3] == kotak[4] && kotak[5] == kotak[4]) {
                status = false;
            } else if (kotak[7] == simbol && kotak[6] == kotak[7] && kotak[8] == kotak[7]) {
                status = false;

            // VERTICAL / Kebawah
            } else if (kotak[4] == simbol && kotak[1] == kotak[4] && kotak[7] == kotak[4]) {
                status = false;
            } else if (kotak[3] == simbol && kotak[0] == kotak[3] && kotak[6] == kotak[3]) {
                status = false;
            } else if (kotak[5] == simbol && kotak[2] == kotak[5] && kotak[8] == kotak[5]) {
                status = false;

            // DIAGONAL / menyamping
            } else if (kotak[4] == simbol && kotak[0] == kotak[4] && kotak[8] == kotak[4]) {
                status = false;
            } else if (kotak[4] == simbol && kotak[2] == kotak[4] && kotak[6] == kotak[4]) {
                status = false;
            }

            // Melihat apakah kotak semuanya sudah terisi
            int sisaKotak = 9;
            for (int i = 0; i < 9; i++) {
                if (kotak[i] != "#") {
                    sisaKotak--;
                }
            }

            // Memutuskan Hasil akhir
            if (status == false && simbol == "X") {
                Console.WriteLine("Komputer menang");
            } else if (status == false && simbol == "O") {
                Console.WriteLine("Player menang");
            } else if (sisaKotak == 0) {
                Console.WriteLine("Seri");
                status = false;
            }

            return status;
        }
    }
}
