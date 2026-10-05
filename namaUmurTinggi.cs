using System;

namespace namaUmurTinggi
{
    class namaUmurTinggi
    {
        static void Main()
        {
            Console.WriteLine("DATA NAMA, UMUR, DAN TINGGI BADAN");

            //input nama
            Console.Write("Masukkan Nama: ");
            string nama = Console.ReadLine();

            //input umur
            Console.Write("Masukkan Umur: ");
            int umur = int.Parse(Console.ReadLine());

            //input tb
            Console.Write("Masukkan Tinggi Badan: ");
            int tb = int.Parse(Console.ReadLine());

            //if else untuk umur

            //kategori umur
            string kategoriUmur;
            if (umur < 20)
            {
                kategoriUmur = "Muda";
            } else if (umur >= 20 && umur <= 40)
            {
                kategoriUmur = "Senior";
            } else if (umur > 40)
            {
                kategoriUmur = "Suhu";
            } else
            {
                kategoriUmur = "tidak valid";
            }

            //switch case untuk tinggi badan

            //kategori tinggi badan

            string kategoriTb;
            switch (tb)
            {
                case < 160 and >= 0:
                kategoriTb = "Pendek";
                break;
                case >= 160 and < 170:
                kategoriTb = "Tinggi";
                break;
                case >= 170 and <= 300:
                kategoriTb = "Tinggi Sekali";
                break;
                default:
                kategoriTb = "tidak valid";
                break;
            }

            string hasil = $"Nama: {nama}, \nUmur: {umur}, Kategori Umur: {kategoriUmur}, \nTinggi Badan: {tb}, Kategori Tinggi: {kategoriTb}";
            Console.WriteLine(hasil);


        }
    }
}