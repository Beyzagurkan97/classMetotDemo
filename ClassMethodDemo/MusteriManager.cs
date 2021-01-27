using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " yeni müşteri eklendi.Yeni müşterinin mesleği: " + musteri.Meslek);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " müşteri silindi");
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşterinin  Adı:" + musteri.Ad);
            Console.WriteLine("Müşterinin  Soyadı:" + musteri.Soyad);
            Console.WriteLine("Müşterinin  ID:" + musteri.Id);
            Console.WriteLine("Müşterinin  Mesleği:" + musteri.Meslek);
        }
    }
}
