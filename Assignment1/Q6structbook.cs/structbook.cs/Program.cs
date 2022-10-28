using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structbook.cs
    {
        struct book
        {

            static void Main()
            {

                int[] bookId = new int[20];
                string[] title = new string[20];
                int[] price = new int[20];
                string[] bookType = new string[20];
                int n;
                Console.WriteLine("enter the number of book details you want");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("enter the bookid");
                    bookId[i] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter the title");
                    title[i] = Console.ReadLine();

                    Console.WriteLine("enter the price");
                    price[i] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter the booktype");
                    bookType[i] = Console.ReadLine();

                }

                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("BookId = {bookId[j]}, Title= {title[j]}, Price = {price[j]}, Booktype = {bookType[j]}");
                Console.ReadLine();
                }
            }
        }
}
