using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface'lerde ona atanan classların referansını tutabiliyor!!!
            ICreditManager ihtiyacKrediManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(mortgageCreditManager, new List<ILoggerService>() { databaseLoggerService, new FileLoggerService() });

            List<ICreditManager> krediler = new List<ICreditManager>() {ihtiyacKrediManager, vehicleCreditManager };
            //applicationManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
