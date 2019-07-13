using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{
    interface Iunloading:Iadder
    {
        int fweight();
        int fvolume();
        Dictionary<Goods, int> inventary();
    }
    class Unloading: Iunloading
    {
        int count { get; set; }

        Dictionary<Goods, int> goodsForUnlouding = new Dictionary<Goods, int>();

        public Unloading()
        {
            count = goodsForUnlouding.Count;
        }

        public Unloading(Dictionary<Goods, int> goods)
        {
            goodsForUnlouding = goods;
            count = goodsForUnlouding.Count;
        }

        public Unloading(Goods good, int n)
        {
            goodsForUnlouding = new Dictionary<Goods, int>();
            goodsForUnlouding.Add(good, n);
            count = goodsForUnlouding.Count;
        }

        public Dictionary<Goods, int> inventary()
        {
            return goodsForUnlouding;
        }

        public int fweight()
        {
            int w = 0;
            foreach (KeyValuePair<Goods, int> pair in goodsForUnlouding)
            {
                w += pair.Value * pair.Key.weight;
            }
            return w;
        }

        public int fvolume()
        {
            int v = 0;
            foreach (KeyValuePair<Goods, int> pair in goodsForUnlouding)
            {
                v += pair.Value * pair.Key.volume;
            }
            return v;
        }

        public void add(Goods good, int n)
        {
            if (!goodsForUnlouding.ContainsKey(good))
                this.goodsForUnlouding.Add(good, n);
            else
                this.goodsForUnlouding[good] += n;
        }

        public void add(Unloading unloading)
        {
            foreach (KeyValuePair<Goods, int> pair in unloading.goodsForUnlouding)
                add(pair.Key, pair.Value);
        }

        public Unloading remove(Goods good, int n)
        {
            if (!this.goodsForUnlouding.ContainsKey(good))
                return null;
            if (n > this.goodsForUnlouding[good])
                return null;
            if (n == this.goodsForUnlouding[good])
            {
                this.goodsForUnlouding.Remove(good);
                return new Unloading(good, n);
            }
            this.goodsForUnlouding[good] -= n;
            return new Unloading(good, n);
        }

        public Unloading remove(Unloading unloading)
        {
            Unloading temp = new Unloading();
            foreach (KeyValuePair<Goods, int> pair in unloading.goodsForUnlouding)
                temp.add(remove(pair.Key, pair.Value));
            return temp;
        }

        public override string ToString()
        {
            string str = "";
            foreach (KeyValuePair<Goods, int> pair in this.goodsForUnlouding)
                str += pair.Key +" - " + pair.Value + "\n";
            return str;
        }
    }
}
