using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Böyle de verilebilir;
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);//Add metodunda productNamei kamera yapınca productNamei kamera yazar çünkü class referans tiptir.

            /*
            int sayi = 100;
            productManager.Sayi(sayi);
            Console.WriteLine(sayi); 
            Sayi metodunda sayi=99 yapmamıza rağmen bunda sayiyi 100 yazar çünkü int değer tiptir.          
            */

            /*
            productManager.Topla2(3, 6);//void ile metod yapıldığında toplam sonuç tekrar kullanılamaz. git yap bititr anlamına gelir void. 
            // return ile yapılan sonucu çıkan toplamı tekrar kullanabilir,döndürebiliriz.
            int toplamaSonucu = productManager.Topla(3, 6);
            */
        }
    }
}
