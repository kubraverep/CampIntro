using System;

namespace CampDegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=? 999

            /*
             int,decimal,float,double,bool = Değer tip
             değer tipler; bellekte stackte gerçekleşir.
             
             array,class,interface = Referans tip
             referans tipler; mesela array oluştururken int[] array kısmına kadar stacte,
             new dediğinde ise heapte bir alan oluşturur ve stackle heapin bağlantısı adreslerle sağlanır.New dendiğinde adres belirlenir.
             sayılar1=sayilar2 dediğimizde sayılar1'in referans adresi sayılar2 nin referans adresine eşitlenir bu yüzden 999 olur.(pointer)
            */
        }
    }
}
