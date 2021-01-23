using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
        //    //Dizileri genişletemezsin.Bu yüzden koleksiyonlar kullanılır.
        //    //Arrayler oluşturulan sınırlar dışında bir eleman eklemene izin vermez.
        //    string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
        //    Console.WriteLine(names[0]);
        //    Console.WriteLine(names[1]);
        //    Console.WriteLine(names[2]);
        //    Console.WriteLine(names[3]);
        //    // isimler[4]= "İlker"; diyerek yeni bir eleman ekleyemeyiz.Arrayin boyutu 3.
        //    names = new string[5];//yeni 5 elemanlı bir dizi oluşturmuş oldun
        //    names[4] = "İlker";
        //    Console.WriteLine(names[4]);//böyle yamarsak ilkeri de yazar
        //    Console.WriteLine(names[0]);//Ama tekrar 0. elemanı yazdığımızda boş yazar.
        //    //Çünkü ne dediğimiz anda boş bir array oluşturup son elemanına ilker demiş olduk .


            List<String> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);//böyle yamarsak ilkeri de yazar
            Console.WriteLine(names2[0]);

        }
    }
}
