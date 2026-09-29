
using System;

namespace Perhitungan
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Menu: 1. Jalur Prestasi 2. Jalur UTBK");
            int pilihan = Convert.ToInt16(Console.ReadLine());

            if (pilihan == 1)
            {
                Japres.prestasi();
            }
            else if (pilihan == 2)
            {
                Utbk.nilai();
            }
        }
    }

    class Japres
    {
        public static void prestasi()
        {
            Console.WriteLine("Masukkan Nilai Matematika:");
            int mtk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan Nilai Bahasa Inggris:");
            int bing = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan Nilai Pilihan:");
            int pil = Convert.ToInt32(Console.ReadLine());

            int total = mtk + bing + pil;
            Console.WriteLine("Total nilai TKA: " + total);

            if (total >= 280)
            {
                Console.WriteLine("Selamat, anda diterima.");
            }
            else
            {
                Console.WriteLine("Mohon maaf, belum memenuhi syarat.");
            }
        }
    }

    class Utbk
    {
        public static void nilai()
        {
            Console.WriteLine("Masukkan nilai TKA:");
            double tka = Convert.ToDouble(Console.ReadLine());

            double dibutuhkan = 600 - (tka * 0.30);
            Console.WriteLine("Nilai UTBK minimal yang dibutuhkan: " + dibutuhkan);
        }
    }
}

