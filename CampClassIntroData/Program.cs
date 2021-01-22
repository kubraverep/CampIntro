using System;

namespace CampClassIntroData
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            

            Kurs kurs1 = new Kurs();//sınıfa ulaşabilmek için
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin DemirOglu";
            kurs1.IzlenmeOran = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOran = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOran = 80;

            // Console.WriteLine(kurs1.KursAdi+ " "+ kurs1.Egitmen); yan yana yazdırma şekli

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (Kurs k in kurslar)
            {
                Console.WriteLine(k.KursAdi+":"+k.Egitmen+ ":"+k.IzlenmeOran);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOran { get; set; }
    }
}
