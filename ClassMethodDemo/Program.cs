using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Beyza";
            musteri1.Soyad = "Can";
            musteri1.Meslek = "Yazılım Mühendisliği";
            musteri1.Id = 1;


            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Osman";
            musteri2.Soyad = "Bawa";
            musteri2.Meslek = "Muhasebeci";
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Özdil";
            musteri3.Meslek = "Öğretmen";
            musteri3.Id = 3;

            MusteriManager musteriyoneticisi = new MusteriManager();
            musteriyoneticisi.Ekleme(musteri1);
            Console.WriteLine("-----");
            musteriyoneticisi.Listeleme(musteri2);
            Console.WriteLine("-----");
            musteriyoneticisi.Silme(musteri3);

        }
    }
}
