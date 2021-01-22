using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri(); //Class tanımlaması - yeni müşteri
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Kosuk";
            musteri1.ID = 210101; //Yıl-Ay-MusteriSırası
            musteri1.TcNo = "11111111111";
            musteri1.TelNo = "05365363666";
            musteri1.Birikim = 7500;
            musteri1.HesapTürü = "Vadeli";

            Musteri musteri2 = new Musteri(); //Class tanımlaması - yeni müşteri
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Kosuk";
            musteri2.ID = 210102; //Yıl-Ay-MusteriSırası
            musteri2.TcNo = "11111111112";
            musteri2.TelNo = "05365363667";
            musteri2.Birikim = 20000;
            musteri1.HesapTürü = "Vadeli";

            Musteri musteri3 = new Musteri(); //Class tanımlaması - yeni müşteri
            musteri3.Adi = "Sabri";
            musteri3.Soyadi = "Tuncer";
            musteri3.ID = 210103; //Yıl-Ay-MusteriSırası
            musteri3.TcNo = "11111111113";
            musteri3.TelNo = "05365363668";
            musteri3.Birikim = 50;
            musteri1.HesapTürü = "Vadesiz";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 }; // Class array oluşturur

            MusteriManager musteriEkleAuto = new MusteriManager();
            //musteriManager.MusteriEkle(musteri1);
            //musteriManager.MusteriEkle(musteri2);
            musteriEkleAuto.MusteriEkleAuto(musteriler);

            Console.WriteLine("-----------------------");

            MusteriManager musteriEkleManuel = new MusteriManager();
            musteriEkleManuel.MusteriEkleManuel(musteri1);

            Console.WriteLine("-----------------------");

            MusteriManager musteriListele = new MusteriManager();
            musteriListele.Listele(musteriler, musteriler.Length);
        }
    }
}
