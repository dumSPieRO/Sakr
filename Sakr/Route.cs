using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{
    interface Iroute : Iadder
    {
        int fweight();
        int fvolume();
        Dictionary<Goods, int> inventary();
        int length();
    }

    class Route:Iroute
    {
        string name;
        List<RoutePoint> routePoints = new List<RoutePoint>();

        public int fvolume()
        {
            int fv = 0;
            foreach (RoutePoint rp in routePoints)
            {
                fv += rp.fvolume() * rp.flag;
            }
            return fv;
        }

        public int fweight()
        {
            int fw = 0;
            foreach (RoutePoint rp in routePoints)
            {
                fw += rp.fweight() * rp.flag;
            }
            return fw;
        }

        public Dictionary<Goods, int> inventary()
        {
            Dictionary<Goods, int> dict = new Dictionary<Goods, int>();
            foreach (RoutePoint routePoint in routePoints)
            {
                Dictionary<Goods, int> temp = routePoint.inventary();
                if (dict.Count == 0)
                    dict = temp;
                else
                {
                    foreach (Goods g in temp.Keys)
                    {
                        if (dict.ContainsKey(g))
                            dict[g] += temp[g];
                        else
                            dict.Add(g, temp[g]);
                    }
                }
            }
            return dict;
        }

        public int length()
        {
            return routePoints.Count;
        }

        public void charge(Goods good, int n)
        {
        
        }
    }
}
