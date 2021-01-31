using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //operasyonlar classını interface haline getiriyoruz
    //Burdaki hesapla metodu tüm kredi tipleri için farklılık gösteren ortak bir metoddur.
    // interface bizim şablonumuz görevini görür.Eğer biri o interfacei kullanırsa içindeki metodları kullanmak zorunda. 
    interface ICreditManager
    {
        void Calculate();//Hesapla
        
    }
}
