using System;

namespace CampDonguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme kampı";
            String kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";/*bir sürü veri olsaydı böyle tek tek değişkenle tanımlamak zor olacaktı
            bu nedenle array(diziler) kullanılır*/
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine();

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java" };
            // bir sürü veriyi tek bir değişkende tutmuş oluyoruz

            for (int i = 0; i < kurslar.Length ; i++)//kurslar.Lenght dizinin keç elemanı varsa onu temsil eder(yani >3 ..0,1,2)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            //kurs bir aliastır(takma isim). dizilerde genelde foreach ile kolay dolaşmak için kullanılır.
            foreach (string kurs in kurslar)//dizi temelli yapıları tek tek dönmeye yarıyor
            {
                Console.WriteLine();
            }
        }
    }
}
