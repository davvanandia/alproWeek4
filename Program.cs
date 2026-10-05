// Contoh Kasus Alpro

using System;

namespace ContohKasusAlpro
{
    class Program
    {
        static void Main()
        {
            // contoh penggunaan if else
            Console.WriteLine("Masukkan angka: ");
            float angka = float.Parse(Console.ReadLine());

            if (angka >= 85 && angka <= 100)
            {
                Console.WriteLine("A");
            }
            else if (angka < 85 && angka >= 75)
            {
                Console.WriteLine("AB");
            }
            else if (angka < 75 && angka >= 65)
            {
                Console.WriteLine("B");
            }
            else if (angka < 65 && angka >= 60)
            {
                Console.WriteLine("BC");
            }
            else if (angka < 60 && angka >= 55)
            {
                Console.WriteLine("C");
            }
            else if (angka < 55 && angka >= 50)
            {
                Console.WriteLine("D");
            }
            else 
            {
                Console.WriteLine("E");
            }


            //contoh penggunaan switch case
            switch (angka)
            {
                case >= 85 and <= 100:
                    Console.WriteLine("A");
                    break;
                case >= 75 and < 85:
                    Console.WriteLine("AB");
                    break;
                case >= 65 and < 75:
                    Console.WriteLine("B");
                    break;
                case >= 60 and < 65:
                    Console.WriteLine("BC");
                    break;
                case >= 55 and < 60:
                    Console.WriteLine("C");
                    break;
                case >= 50 and < 55:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("E");
                    break;
            }
            // contoh penggunaan switch expression

            string hasil = angka switch
            {
                >= 85 and <= 100 => "A",
                >= 75 and < 85 => "AB",
                >= 65 and < 75 => "B",
                >= 60 and < 65 => "BC",
                >= 55 and < 60 => "C",
                >= 50 and < 55 => "D",
                _ => "E"
            };
            Console.WriteLine(hasil);

            if (angka >= 100)
            {
                Console.WriteLine("Nilai anda sempurna");
            } else
            {
                Console.WriteLine("Nilai anda belum sempurna");
            }

            // contoh penggunaan ternary operator
            string result2 = (angka == 100) ? "Nilai anda sempurna" : "Nilai anda belum sempurna";
            Console.WriteLine(result2);
        }
    }
}