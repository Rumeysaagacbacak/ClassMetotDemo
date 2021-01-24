using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = " Rümeysa ";
            musteri1.Soyadi = " Ağaçbacak ";
            musteri1.Gelir = 5000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = " Rabia ";
            musteri2.Soyadi = " Ağaçbacak ";
            musteri2.Gelir = 3000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = " Engin ";
            musteri3.Soyadi = " Demiroğ ";
            musteri3.Gelir = 6000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };



            foreach (var musteri in musteriler)
            {
                Console.WriteLine(" Müşteri Id: " + musteri.Id);
                Console.WriteLine(" Müşteri Adı: " + musteri.Adi);
                Console.WriteLine(" Müşteri Soyadı: " + musteri.Soyadi);
                Console.WriteLine(" Müşteri Geliri: " + musteri.Gelir);
                Console.WriteLine("----------------");
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);

        }
    }
}
