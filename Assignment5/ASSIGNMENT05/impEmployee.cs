using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT05
{
    internal class impEmployee
    {

        public static void Main()
        {
            try
            {
                ArrayList employees = new ArrayList();

                employees.Add(new employee());
                ((employee)employees[0]).name = "sid";
                ((employee)employees[0]).age = 20;
                ((employee)employees[0]).salary = 15000;
                Console.WriteLine(((employee)employees[0]).getData());

                employees.Add(new employee());
                ((employee)employees[1]).name = "nina";
                ((employee)employees[1]).age = 25;
                ((employee)employees[1]).salary = 20000;
                Console.WriteLine(((employee)employees[1]).getData());

                employees.Add(new employee());
                ((employee)employees[2]).name = "stefan";
                ((employee)employees[2]).age = 19;
                ((employee)employees[2]).salary = 25000;
                Console.WriteLine(((employee)employees[2]).getData());

                employees.Add(new employee());
                ((employee)employees[3]).name = "damon";
                ((employee)employees[3]).age = 29;
                ((employee)employees[3]).salary = 35000;
                Console.WriteLine(((employee)employees[3]).getData());
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
