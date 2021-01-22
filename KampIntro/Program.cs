using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {   //type safety-tip güvenliği (bir değişkenin başına veri tipini yazmak zorundasın)
            //Do not repeat yourself-Kendini tekrarlama, değişken kullan
            //kategoriEtiketi değer tutucu,aliastır
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;//true false olan kısım veri tabanından gelir genelde
            double dolarDun =7.35;
            double dolarBugun = 7.45;

            //sisteme giris yapmadıysa giris yap butonunu, yaptıysa kullanıcı ayarları gösteriyor sitede 
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
