using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{
    class Goods
    {
        public override string ToString()
        {
            return $"Груз:: \n Наименование: {name} \n Масса: {mas} \n Объем: {v}";
        }
        public int mas
        {
            get;
            set;
        }
        public int v
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
    }
}
