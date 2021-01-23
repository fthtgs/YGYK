using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer musteri1 = new IndividualCustomer();
            musteri1.Id = 1;
            musteri1.CustomerNo = "12345";
            musteri1.FirstName = "Engin";
            musteri1.LastName = "Demiroğ";
            musteri1.TcNo = "12345678910";


            //Kodlama.io
            CorporateCustomer musteri2 = new CorporateCustomer();
            musteri2.Id = 2;
            musteri2.CustomerNo = "54321";
            musteri2.CompanyName = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID


            //Customer class can hold both different types of customers as well.
            Customer musteri3 = new IndividualCustomer();
            Customer musteri4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
