using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //Class tanımlamak için yapıyoruz
            // <Class_adı> variable = new <Class_adı>();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 }; // Class array oluşturur

            //type-safe -> tip güvenli yazılım dili
            foreach (Urun urun in urunler) //urunler dizisini gez dataları ekrana bas - <urun> verilen takma ad
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("--------Metotlar-------");

            //Instance - Örnek oluşturma
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            // Sayfa 1
            sepetManager.Ekle(urun1);
            // Sayfa 2
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armur", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 1);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 2);

        }
    }
}


//Dont repeat yourself!!! - DRY - Clean Code - Best Practice