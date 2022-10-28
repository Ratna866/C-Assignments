using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT05
{
    internal class clear
    {
        static void Main()
        {

            string[] fruits = new string[4];
            Console.WriteLine("enter the array of strings:");
            for (int i = 0; i < fruits.Length; i++)
            {
                fruits[i] = Console.ReadLine();

            }
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + " ");
            }
            Console.ReadLine();
            Console.WriteLine("Array (Old):");
            foreach (var val in fruits)
            {
                Console.WriteLine(val);
            }
            Array.Clear(fruits,0, fruits.Length);
            Console.WriteLine("Array (After using Clear):");
                foreach (var fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }




            int[] arr = new int[4];
            Console.WriteLine("enter the array value:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
            Console.WriteLine("Array (Old):");
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }

            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("Array (After using Clear):");
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }
    }
}
