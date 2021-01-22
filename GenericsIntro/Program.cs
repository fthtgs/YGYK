using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Emre");
            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);

            List<string> isimler2 = new List<string>();
            isimler2.Add("Emre");
            isimler2.Add("Kerem");
            Console.WriteLine(isimler.Length);
            Console.WriteLine(isimler2[1]);


            /*
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            */



            Console.WriteLine("Hello World!");
        }
    }
}
