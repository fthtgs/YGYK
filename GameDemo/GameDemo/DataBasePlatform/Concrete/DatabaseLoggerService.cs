using GameDemo.DataBasePlatform.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.DataBasePlatform.Concrete
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add()
        {
            Console.WriteLine("Veritabanına satın alım eklenmiştir.");
        }
    }
}
