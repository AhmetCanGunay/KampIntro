using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> {"Engin","Murat","Halil" };
            Console.WriteLine(isimler2[0]);
            isimler2.Add("Ahmet");
            Console.WriteLine(isimler2[3]);
            
        }
    }
}
