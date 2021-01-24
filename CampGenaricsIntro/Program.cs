using System;

namespace CampGenaricsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();//T string yerine geçmiş oldu
            names.Add("Engin");
        }
    }
}
