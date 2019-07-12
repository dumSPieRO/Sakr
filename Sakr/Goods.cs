using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{

    class Goods
    {
        public Goods(string name, int weight, int volume)
        {
            this.name = name;
            this.weight = weight;
            this.volume = volume;
        }
        public string name { get; set; }
        public int weight { get; set; }
        public int volume { get; set; }

        public override string ToString()
        {
            return name + $" (масса: {weight}, объём: {volume})";
        }
    }
}
