using System;
using System.Collections.Generic;
using System.Text;
//her kredi creditManager interfacesi içindeki metodları kullanmak zorundadır.
namespace OOP3
{
    class TasıtCreditManager : ICreditManager
    {
        //Kendi kuralına göre hesapla metodunu yapabilir.
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
