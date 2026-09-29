using System;
namespace Tugas1
{
    class Tugaspercabangan
    {
        static void Main()
        {

            string diskon = "tidak mendapatkan diskon";
            int buku1 = 300;
            int buku2 = 200;
            int buku3 = 100;
            int bulpen = 500;

            double diskon1 = 20;
            double diskon2 = 10;
            double batasdiskon1 = 1000;
            double batasdiskon2 = 700;

            double total = buku1 + buku2 + buku3 + bulpen * 2;
            double syaratdiskon = total - buku3;
            double totaldiskon = syaratdiskon;
            

            if (total >= batasdiskon1)
            {
                syaratdiskon = (syaratdiskon * diskon1 ) / 100;
                syaratdiskon = totaldiskon - syaratdiskon;
                    
            }
            else if (total >= batasdiskon2)
            {

                syaratdiskon = (syaratdiskon * diskon2) / 100;
                syaratdiskon = totaldiskon - syaratdiskon;

            }

            Console.WriteLine("harga yang harus dibayar :" + syaratdiskon);



        }
    }


}
