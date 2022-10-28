using System;
using LitwareLib;

namespace CSharp_Assignment2
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("enter no.of employee");
                int size = Convert.ToInt32(Console.ReadLine());
                Employee[] obj1 = new Employee[size];
                Employee obj = new Employee();

                Console.WriteLine("----------Accepting Employee Details----------");

                for (int i = 0; i < size; i++)
                {
                    
                    Console.WriteLine("Enter Employee Number:");
                    int no = int.Parse(Console.ReadLine());
                    obj.setempno(no);

                    Console.WriteLine("Enter Employee Name:");
                    string name = Console.ReadLine();
                    obj.setempname(name);

                    Console.WriteLine("Enter Employee Salary:");
                    double salary = double.Parse(Console.ReadLine());
                    obj.setEmpSalary(salary);
                    obj.sethra();
                    obj.setta();
                    obj.setda();
                    obj.setgs();
                    obj.calculatesalary();
                }

            Console.WriteLine("----------displaying Employee Details----------");
                for (int i = 0; i < size; i++)
                {
                    
                    obj.getEmpNo();
                    obj.getEmpName();
                    obj.getEmpSalary();
                    obj.getgs();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
        }
    }
}