using System;
using System.Collections.Generic;

namespace myDictionaryHW
{
    class Program
    {
        
        static unsafe void Main(string[] args)
        {
            Dictionary<int, string> cities = new Dictionary<int, string>();
            cities.Add(01, "Adana");
            cities.Add(16, "Bursa");
            //cities.Add(16, "Bursa");
            Console.WriteLine(cities.Count);
            Console.WriteLine(cities[16]);


            MyDictionary<int, string> cities2 = new MyDictionary<int, string>();
            cities2.Add(01, "Adana");
            cities2.Add(16, "Bursa");
            //cities2.Add(16, "Bursa");
            Console.WriteLine(cities2.Count);
            //Console.WriteLine(cities2[5]);
            


            
            MyDictionary2<int, string> cities3 = new MyDictionary2<int, string>();
            cities3.Add(01, "Adana");
            cities3.Add(16, "Bursa");
            //cities3.Add(16, "Bursa");
            Console.WriteLine(cities3.Count);
            //Console.WriteLine(cities3[1]);
            
        }
        
    }
}
