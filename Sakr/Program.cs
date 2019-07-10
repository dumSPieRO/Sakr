using System;

namespace Sakr
{
    //Dev
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">Аргументы</param>
        static void Main(string[] args)
        {
            var a = new Goods();
            a.name = "ООО евроопт";
            a.mas = 4;
            a.v = 2;
            Console.WriteLine("Hello World! developer");
            var g = new Transport("", 10000000, 11000);
            g.add(a, 13);
            g.add(a, 12);
            g.add(a, 116);
            Console.WriteLine(g);

        }
    }
}
