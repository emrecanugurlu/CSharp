using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "1234";
            gercekMusteri.Adi = "Ali";
            gercekMusteri.Soyadi = "Veli";
            gercekMusteri.TcNo = "12345678";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 1;
            tuzelMusteri.MusteriNo = "12345678";
            tuzelMusteri.SirketAdi = "ECU";
            tuzelMusteri.VergiNo = "123456789";

            Musteri musteri1 = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
