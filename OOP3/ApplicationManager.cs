using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{   //Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    //Bu örnekte tüm kredi türleri için hesaplama metodu ortaktır fakat hesaplama kuralları farklıdır.Bu yüzden Interface kullandık.
    //BasvuruManager
    class ApplicationManager
    {

        //Başvuru metodunun içine ICrediManager  yazarak tüm kredi tiplerine ulaşmış olduk.
        public void MakeApplication(ICreditManager creditManager,ILoggerService loggerService)
        {
            /*kredi hesaplamak istendiğinde;
            KonutCreditManager konutCreditManager = new KonutCreditManager();
            konutCreditManager.Calculate();*///şeklinde denirse bütün başvurular konut kredisine göre hesaplanır.
            creditManager.Calculate();
            loggerService.Log();
            //Method injection
        }

        // list içinde seçilen kredi tiplerine göre hesaplama yapam metod
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)// türü ICreditManager olan bir liste ver
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            } 
        }
    }
}
