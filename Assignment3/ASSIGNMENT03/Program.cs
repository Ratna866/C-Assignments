using System.Runtime.Serialization.Formatters.Binary;
using ClassLibrary1;

namespace Assignment03
{
    public class Program
    {

        static void Main(string[] args)
        {

            Employee obj = new Employee();
            Console.WriteLine("----------Accepting Employee Details----------");

            Console.WriteLine("Enter Employee Number:");
            int no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            double salary = double.Parse(Console.ReadLine());


            FileStream f = new FileStream(@"D:\sample\employee.txt", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(f, obj);
            f.Close();


            FileStream fr = new FileStream(@"D:\sample\employee.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter br = new BinaryFormatter();
            br.Deserialize(fr);

            obj.setEmpDetails(no, name, salary);

            Console.WriteLine("\n----------Displaying Employee Details----------");

            obj.getEmpDetails();

            double resultHRA = obj.setHRA(salary);
            Console.WriteLine("Your HRA is: {0}", resultHRA);

            double resultTA = obj.setTA(salary);
            Console.WriteLine("Your TA is: {0}", resultTA);

            double resultDA = obj.setDA(salary);
            Console.WriteLine("Your DA is: {0}", resultDA);

            double grossSalary = obj.getGrossSalary(salary, resultHRA, resultDA, resultTA);
            Console.WriteLine("Your Gross Salary is: {0}", grossSalary);

            obj.CalculateSalary(grossSalary);
            obj.showSalary();




            //create a list
            List<string> list = new List<string>();
            //add elements in the list
            list.Add(name);//here name is string which used to enter the employeename in the main method 

            Console.WriteLine("enter the employee name to search");
            string target = Console.ReadLine();

            bool isexist = list.Contains(target);
            if (isexist)
            {
                Console.WriteLine("Element found in the list");
            }
            else
            {
                Console.WriteLine("Element not found in the given list");
            }
            Console.ReadLine();






            Console.WriteLine("\n----------Displaying Manager Details----------");

            Manager obj1 = new Manager();

            double petrol = obj1.setPetrol(salary);
            Console.WriteLine("Petrol Allowance: {0}", petrol);

            double food = obj1.setFood(salary);
            Console.WriteLine("Food Allowance: {0}", food);

            double other = obj1.setOther(salary);
            Console.WriteLine("Other Allowance: {0}", other);

            double gross1 = obj1.getGrossSalary(salary, resultHRA, resultDA, resultTA);
            double gross2 = obj1.setAllowance(petrol, food, other);
            double result_gross = gross1 + gross2;
            Console.WriteLine("Gross Salary of Manager on adding the Allowances is: {0}", result_gross);

            obj.CalculateSalary(result_gross);
            obj.showSalary();

            Console.WriteLine("\n---------Displaying Marketing Executive----------");

            MarketingExecutive obj2 = new MarketingExecutive();

            Console.WriteLine("Enter Kilometer Travel: ");
            double travel = double.Parse(Console.ReadLine());
            obj2.setTravel(travel);
            obj2.getTravel();

            double tour = obj2.setTour(travel);
            obj2.getTour();

            double tele = obj2.setTelephone();
            Console.WriteLine("Telephone Allowances are: Rs.{0}", tele);

            double gross3 = obj2.setAllowance(travel, tour, tele);
            double result_gross_final = result_gross + gross3;
            Console.WriteLine("Gross Salary of Marketing Executive on adding the Allowances is: {0}", result_gross_final);

            obj2.CalculateSalary(result_gross_final);
            obj2.showSalary();

            Console.ReadLine();
        }
    }
}
