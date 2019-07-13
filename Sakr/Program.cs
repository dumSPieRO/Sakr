using System;
using System.Collections.Generic;

namespace Sakr
{
    //Dev
    class Program
    {
        static void Main(string[] args)
        {
            Goods g1 = new Goods("Мороженко", 5, 12);
            Goods g2 = new Goods("Конфетки", 1, 1);
            Unloading unloading = new Unloading(g1, 20);

            Console.WriteLine(unloading);
            unloading.add(g2, 100);
            Console.WriteLine(unloading);
            unloading.add(g1, 10);
            Console.WriteLine(unloading);
            unloading.remove(g2, 50);
            Console.WriteLine(unloading);
            unloading.remove(g2, 50);
            Console.WriteLine(unloading);
           
        }
    }

    interface Iadder
    {
        int fweight();
        int fvolume();
        Dictionary<Goods, int> inventary();
    }


    
}