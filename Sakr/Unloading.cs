using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{

    class Unloading
    {
        int count { get; set; }
        Dictionary<Gooods, int> goodsForUnlouding = new Dictionary<Gooods, int>();

        public Unloading()
        {
            count = goodsForUnlouding.Count;
        }

        public void Charge(int n, Gooods goods)
        {
            goodsForUnlouding.Add(goods, n);
        }

        public Dictionary<Gooods, int> inventary()
        {
            return goodsForUnlouding;
        }

    }
}
