using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrsum.cs
{
    public class arrsum
    {
        private static void Sum()
        {
            int i, n, sum = 0;
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[100];
            for (i = 0; i < n; i++)
            {
                Console.Write("please enter the numbers :");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Sum of all elements stored in the array is : {0}\n\n", +sum);
            Console.ReadLine();
        }
        public static void Main()
        {
            arrsum.Sum();
            Console.ReadKey();
        }
    }
}