using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT03
{
    internal class StackMain
    {
        static void Main()
        {
            MyStack S = new MyStack(3);

            try
            {
                S.push(133);
                S.push(213);
                S.push(768);
                S.push(140);
                S.push(15);
                S.push(10);
            }
            catch (StackException se)
            {
                Console.WriteLine(se);
            }


            try
            {
                //S.pop();
                //S.pop();

            }
            catch (StackException se)
            {
                Console.WriteLine(se);
            }

            try
            {
                S.displayStack();
            }
            catch (StackException se)
            {
                Console.WriteLine(se);
            }

            Console.ReadLine();
        }
    }

    public class StackException : Exception
    {
        public StackException(string s) : base(s)
        {

        }
    }

}

