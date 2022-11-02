using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class arithmaticoperations
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int sum,sub,mul,div;
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        sum = num1 + num2;
                        Console.WriteLine("Addition:" + sum);
                        break;
                    case "-":
                        sub = num1 - num2;
                        Console.WriteLine("Subtraction:" + sub);
                        break;
                    case "*":
                        mul = num1 * num2;
                        Console.WriteLine("Multiplication:" + mul);
                        break;
                    case "/":
                        div = num1 / num2;
                        Console.WriteLine("Division:" + div);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }

}
