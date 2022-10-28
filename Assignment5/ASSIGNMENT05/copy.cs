using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT05
{
    internal class copy
    {
        public static void Main(string[] args)
        {
            
            string[] fruits = new string[4];
            string[] fruit2 = new string[fruits.Length];
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

            Console.WriteLine("copy method of string array");

            Array.Copy(fruits, fruit2, 2);

            foreach (var fruit in fruit2)
            {
                Console.WriteLine(fruit);
            }





            int[] arr = new int[4];
            Console.WriteLine("Copy of integer array");
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();

            Console.WriteLine("copy method of integer array");

            Array.Copy(arr,arr2,2);
            foreach (int val in arr2)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }
    }
}
