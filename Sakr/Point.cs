using System;
using System.Collections.Generic;
using System.Text;

namespace Sakr
{
    class Point
    {
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
         public override string ToString()
        {
            return $"Точка:: \n Наименование: {name} \n Координаты:: х: {x} y: {y}"; ;
        }
        public int x { get; set; }
        public int y { get; set; }
        public string name { set; get; }

        public Point(string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
