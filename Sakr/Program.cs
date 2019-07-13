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


    interface ITransport: Iadder
    {

        int fweight();
        int fvolume();
        Dictionary<Goods, int> inventary();
    }

    class Transport : ITransport
    {
        public string name{get; set;}
        public int weight{get; set;}
        public int volume{get; set;}
        public Route route { get; set; }
        public int fweight()
        {
            return route.fweight();
        }
        public int fvolume()
        {
            return route.fvolume();
        }
        public bool charge(Goods good, int n)
        {
            return true;
        }
        public bool charge(string name, int n)
        {
            return true;
        }

        public bool discharge(int n, string name)
        {
            return true;
        }

        public bool limit()
        {
            return true;
        }

        public Dictionary<Goods, int> inventary()
        {
            return route.inventary();
        }
    }
}