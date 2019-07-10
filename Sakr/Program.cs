using System;

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
        int inventory();
    }


    interface ITransport: Iadder
    {
        string name;
        int weight;
        int volume;

        int fweight();
        int fvolume();
        int inventory();
    }

    class Transport : ITransport
    {
        public string name{get; set;}
        public int weight{get; set;}
        public int volume{get; set;}

        public int fweight()
        {

        }
        public int fvolume()
        {

        }
        public int inventory()
        {

        }

        public void charge(int n, string name)
        {

        }
        public void charge(string name)
        {

        }

        public void discharge(int n, string name)
        {

        }

        public bool limit()
        {
            return true;
        }

    }

}
