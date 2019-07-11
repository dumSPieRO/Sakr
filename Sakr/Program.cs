using System;
using System.Collections.Generic;

namespace Sakr
{
    //Dev
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! developer");
            Console.WriteLine("Git");
        }
    }

    interface Iadder
    {
        int fweight();
        int fvolume();
        Dictionary<Gooods, int> inventary();
    }


    interface ITransport: Iadder
    {

        int fweight();
        int fvolume();
        Dictionary<Gooods, int> inventary();
    }

    class Transport : ITransport
    {
        public string name{get; set;}
        public int weight{get; set;}
        public int volume{get; set;}
        public Route route { get; set; }
        public int fweight()
        {
            return 0;
        }
        public int fvolume()
        {
            return 0;
        }
        public void charge(Gooods good, int n)
        {
        }
        public void charge(string name, int n)
        {

        }

        public void discharge(int n, string name)
        {

        }

        public bool limit()
        {
            return true;
        }

        public Dictionary<Gooods, int> inventary()
        {
            return route.inventary();
        }
    }

}
