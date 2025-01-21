using System;
using System.Collections.Generic;

namespace KahveDunyasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boş bir string listesi oluşturuyoruz
            List<string> kahveListesi = new List<string>();

            // Kullanıcıdan 5 kahve ismi alıyoruz
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}. kahveyi giriniz: ", i + 1);
                string kahve = Console.ReadLine();
                kahveListesi.Add(kahve);
            }

            // Listedeki tüm kahve isimlerini ekrana yazdırıyoruz
            Console.WriteLine("\nKahve Listesi:");
            foreach (string kahve in kahveListesi)
            {
                Console.WriteLine(kahve);
            }
        }
    }
}