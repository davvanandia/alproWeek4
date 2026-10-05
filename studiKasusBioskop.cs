using System;

namespace kasusBioskop
{
    class Bioskop
    {
        static void Main()
        {
            Console.WriteLine("PEMESANAN TIKET BIOSKOP");
            //jmlTiket
            Console.Write("Jumlah Tiket: ");
            int jmlTiket = int.Parse(Console.ReadLine());

            //status member
            Console.Write("Status Member (y/n): ");
            string statusMember = Console.ReadLine();

            //harga tiket awal
            int hargaTiket = 50000;

            //jika member maka disc 20% 
            if (statusMember == "y")
            {
                hargaTiket = hargaTiket - (hargaTiket * 20/100); 
            } else if (statusMember == "n")
            {
                //

            } else
            {
                Console.WriteLine("tidak valid");
                return;
            }

            //jika jmlTiket >= 5 maka disc 10%
            if (jmlTiket > 5)
            {
                hargaTiket = hargaTiket - (hargaTiket * 10/100);
            } else
            {
                //
            }

            //total bayar 
            int totalBayar = hargaTiket * jmlTiket;
            Console.WriteLine("Total Bayar: " + totalBayar);

        }
    }
}