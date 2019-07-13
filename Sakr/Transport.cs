using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{
    interface ITransport : Iadder
    {

        int fweight();
        int fvolume();
        Dictionary<Goods, int> inventary();
    }

    class Transport : ITransport
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int volume { get; set; }
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
