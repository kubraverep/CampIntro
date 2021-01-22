using System;
using System.Collections.Generic;
using System.Text;

namespace CampMethods
{
    //Manager varsa bir operasyon vardır. metodla ilgili işlemler olur
    public class SepetManager
    {
        public void Ekle(Product product)//Ekle metodu ve Urun parametresi. Product sınıfından kapsülleme yaptık.
        {
            Console.WriteLine(product.Adi+"sepete eklendi");
        }

        //böyle bir metodda başka bir özellik eklediğinde tek tek değiştirmen gerekecektir.Tüm sayfalar patlar.
        //bunun için kapsüllenmiş hali yani ilk metoddaki gibi kullanılır(encapsulation).
        public void Ekle2(string urunAdi,string urunAcıklama,double urunFiyat,int urunStok)
        {
            Console.WriteLine(urunAdi + "sepete eklendi");
        }
    }
}
