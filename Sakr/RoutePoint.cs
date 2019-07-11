using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{
    interface IroutePoint : Iadder
    {
        int fweight();
        int fvolume();
        Dictionary<Gooods, int> inventary();
        void WeNeed(Gooods goods, int n);
    }
    class RoutePoint : IroutePoint
    {
        public Unloading needgoods;

        public int fvolume()
        {
            throw new NotImplementedException();
        }

        public int fweight()
        {
            throw new NotImplementedException();
        }

        public Dictionary<Gooods, int> inventary()
        {
            return needgoods.inventary();
        }

        public void WeNeed(Gooods goods, int n)
        {
            needgoods.Charge(n, goods);
        }
    }
}
