using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{
    class Transport
    {
        public override string ToString()
        {
            var result = "";
            foreach (var item in gr)
            {
                result += $"{item.Key} \n Количество:: {item.Value}";
            }
            return result;
        }
        public Transport(string name, int mas, int v)
        {
            this.name = name;
            this.mas = mas;
            fmas = mas;
            this.v = v;
            fv = v;
            
        }
        Dictionary<Goods, int> gr = new Dictionary<Goods, int>();
        public string name { get; set; }
        public int mas { get; set; }
        public int v { get; set; }
        private int fmas { get; set; }
        private int fv { get; set; }
        public bool add(Goods goods, int n)
        {
            if ((goods.mas * n) < fmas)
            {
                if (gr.ContainsKey(goods))
                {
                    gr[goods] += n;
                }
                else
                {
                    gr.Add(goods, n);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool add(Goods goods)
        {
            return add(goods, 1);
        }
    }
}
