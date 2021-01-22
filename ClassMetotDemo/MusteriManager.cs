using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleManuel(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Sisteme Eklendi!");
        }
        public void MusteriEkleAuto(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Sisteme Eklendi!");
            }

        }
        public void Listele(Musteri[] musteriler, int x)
        {
            Console.WriteLine("Müşteri Listesi : ");
            Console.WriteLine("Adı  " + "Soyadı " + "   TcNo       " + "   ID   " + "  Tel No   " + "       Birikim");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(musteriler[i].Adi + " " + musteriler[i].Soyadi + "    " + musteriler[i].TcNo + "  " + musteriler[i].ID + "    " + musteriler[i].TelNo + "    " + musteriler[i].Birikim);
            }
        }
        public void Silme(Musteri[] musteriler, int x)
        {

        }
    }
}
