using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{
    interface IroutePoint : Iadder
    {
        int fweight();
        int fvolume();
        Dictionary<Goods, int> inventary();
        void discharge(Unloading goods);
    }
    class RoutePoint : IroutePoint
    {
        public Unloading needgoods { get; set; }    //Здесь инфа про необхожимые грузы
        public Unloading deliveredgoods { get; set; }
        public short flag { get; set; }     //Здесь инфа о прохождении машины точки
        public bool isComplite { get; set; }//Здесь инфа о выполнении запроса
        public Point position { get; set; }

        public RoutePoint(Dictionary<Goods, int> goods)
        {
            flag = 1;
            isComplite = false;
            needgoods = new Unloading(goods);
        }

        public RoutePoint(Unloading goods)
        {
            flag = 1;
            isComplite = false;
            needgoods = goods;
        }

        public int fvolume()
        {
            return needgoods.fvolume();
        }

        public int fweight()
        {
            return needgoods.fweight();
        }

        public Dictionary<Goods, int> inventary()
        {
            return needgoods.inventary();
        }

        public void discharge(Unloading goods)
        {
            deliveredgoods.add(needgoods.remove(goods));
            flag = 0;
            if (needgoods == null)
                isComplite = true;
        }

        public void discharge(Goods good, int n)
        {
            deliveredgoods.add(needgoods.remove(good, n));
            flag = 0;
            if (needgoods == null)
                isComplite = true;
        }
        //qwe
        public void discharge(Dictionary<Goods, int> dict)
        {
            foreach (KeyValuePair<Goods, int> pair in dict)
            {
                deliveredgoods.add(needgoods.remove(pair.Key, pair.Value));
                flag = 0;
                if (needgoods == null)
                    isComplite = true;
            }
        }

    }
}
