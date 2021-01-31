using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //her kredi creditManager interfacesi içindeki metodları kullanmak zorundadır.
    class KonutCreditManager : ICreditManager
    {
        //Kendi kuralına göre hesapla metodunu yapabilir.
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
