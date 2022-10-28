using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class _4swap
{
    private static void Swap()
    {
        int x, y;
        Console.WriteLine("enter first number");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter second number");
        y = Convert.ToInt32(Console.ReadLine());
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine("values after swapping");
        Console.WriteLine("x is:"+x);
        Console.WriteLine("y is:"+y);
        Console.ReadLine();
    }
    static void Main(string[] args)
        {
        _4swap.Swap();
        Console.ReadKey();
    }
    }

