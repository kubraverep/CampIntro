using System;

//methodlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır
//Do not repeat yourself-DRY- CLEAN CODE-Best Practise

namespace CampMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();//product classının bir örneğini oluşturmuş oluyoruz
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            //type safe
            foreach (Product urun in urunler)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }


            
            Console.WriteLine("************METODLAR************");
            SepetManager sepetManeger = new SepetManager();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);
            Console.WriteLine("************************");
            sepetManeger.Ekle2("Armut","Yeşil",12,3);
            sepetManeger.Ekle2("Elma", "Yeşil", 10,5);
            Console.WriteLine("************************");
        }
    }
}
