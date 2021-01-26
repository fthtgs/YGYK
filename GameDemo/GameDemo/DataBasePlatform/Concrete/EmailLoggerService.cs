using GameDemo.DataBasePlatform.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.DataBasePlatform.Concrete
{
    class EmailLoggerService : ILoggerService
    {
        public void Add()
        {
            Console.WriteLine("Satın alım kullanıcının email adresine gönderilmiştir.");
        }
    }
}
