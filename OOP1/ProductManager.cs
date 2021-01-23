using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"eklendi");
            //product.ProductName = "Kamera"; Adresteki değeri kamera yaptık
        }


      /*  public void Sayi(int sayi)
        {
            sayi = 99;
        }
        */

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }


        /*
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
        */
    }
}
