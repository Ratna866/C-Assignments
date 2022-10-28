using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Highestm
{

    static void Main(string[] args)
    {
        int i = 0;
        int sum = 0;
        int highest = 0;
        int[] mark = new int[5];
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Please enter students marks:");
            mark[i] = Convert.ToInt32(Console.ReadLine());
            {
                if (mark[i] > highest)
                    highest = mark[i];
            }

        }
        Console.WriteLine("The highest marks among all students :"+ highest);
        Console.ReadLine();
    }
}