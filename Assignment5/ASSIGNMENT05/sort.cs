
using System.Collections.Generic;


namespace ASSIGNMENT05
{
    internal class sort
    {
        public static void Main(string[] args)
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
            Console.WriteLine("sort of array string");

            Array.Sort(fruits);

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
            Console.WriteLine("Sort of array Integer");
            Array.Sort(arr);
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }
    }
}
