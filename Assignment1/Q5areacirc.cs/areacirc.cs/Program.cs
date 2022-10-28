using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areacirc.cs
{
    public class areacirc
    {
        public static void Area()
        {

            double r, circum, area;
            double PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            circum = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle : {0}", circum);
            area = PI * r * r;
            Console.WriteLine("area of Circle : {0}", area);
            Console.Read();
        }
        public static void Main()
        {
            areacirc.Area();
            Console.ReadKey();
        }
    }
}