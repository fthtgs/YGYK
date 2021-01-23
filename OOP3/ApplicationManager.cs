using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Method injection
    class ApplicationManager
    {
        //ICreditManager hepsini tuttuğu için hangisini fonksiyon içine gönderirse
        //o kredi hesaplanır.
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Calculate();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }
        //Girilecek kredi sayısı belli olmadığı için array olarak tutmak daha mantıklı
        //fonksiyona array göndermek için en mantıklı kullanım da array oluşturan List komutudur.
        //
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)
        {
            // Listedeki her kredinin hesabını yaptırmak için foreach kullandık
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
        
    }
}
