using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{
    interface Iroute : Iadder
    {
        int fweight();
        int fvolume();
        Dictionary<Gooods, int> inventary();
        int length();
    }

    class Route:Iroute
    {
        string name;
        List<RoutePoint> routePoints = new List<RoutePoint>();
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
            Dictionary<Gooods, int> dict = new Dictionary<Gooods, int>();
            foreach (RoutePoint routePoint in routePoints)
            {
                Dictionary<Gooods, int> temp = routePoint.inventary();
                if (dict.Count == 0)
                    dict = temp;
                else
                {
                    foreach (Gooods g in temp.Keys)
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

        public void charge(Gooods good, int n)
        {
        
        }
    }
}
