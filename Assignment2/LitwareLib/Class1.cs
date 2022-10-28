using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    public class Employee
    {
        int EmpNo;
        string EmpName;
        double Salary;
        double HRA;
        double TA;
        double DA;
        double PF;
        double TDS;
        double NetSalary;
        double GrossSalary;

        public void setempno(int empno)
        {
            this.EmpNo = empno;
        }
        public void getEmpNo()
        {
            Console.WriteLine("Employee Number is: " + this.EmpNo);
        }

        public void setempname(string empname)
        {
            this.EmpName = empname;
        }
        public void getEmpName()
        {
            Console.WriteLine("Employee Name is: " + this.EmpName);
        }

        public void setEmpSalary(double Sal)
        {
            this.Salary = Sal;
        }
        public void getEmpSalary()
        {
            Console.WriteLine("Employee Salary is: " + this.Salary);
        }
        public void sethra()
        {
            double hra;
            switch (Salary)
            {
                case double n when n > 0 & n < 5000:
                    hra = (10 * Salary) / 100;
                    this.HRA = hra;
                    break;
                case double n when n > 5000 & n < 10000:
                    hra = (15 * Salary) / 100;
                    this.HRA = hra;
                    break;
                case double n when n > 10000 & n < 15000:
                    hra = (20 * Salary) / 100;
                    this.HRA = hra;
                    break;
                case double n when n > 15000 & n < 20000:
                    hra = (25 * Salary) / 100;
                    this.HRA = hra;
                    break;
                case double n when n >= 20000:
                    hra = (30 * Salary) / 100;
                    this.HRA = hra;
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }
        public void gethra()
        {
            Console.WriteLine("Employee HRA is: " + this.HRA);
        }
        public void setta()
        {
            double ta;
            switch (Salary)
            {
                case double n when n > 0 & n < 5000:
                    ta = (5 * Salary) / 100;
                    this.TA = ta;
                    break;
                case double n when n > 5000 & n < 10000:
                    ta = (10 * Salary) / 100;
                    this.TA = ta;
                    break;
                case double n when n > 10000 & n < 15000:
                    ta = (15 * Salary) / 100;
                    this.TA = ta;
                    break;
                case double n when n > 15000 & n < 20000:
                    ta = (20 * Salary) / 100;
                    this.TA = ta;
                    break;
                case double n when n >= 20000:
                    ta = (25 * Salary) / 100;
                    this.TA = ta;
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }
        public void getta()
        {
            Console.WriteLine("Employee TA is: " + this.TA);
        }
        public void setda()
        {
            double da;
            switch (Salary)
            {
                case double n when n > 0 & n < 5000:
                    da = (15 * Salary) / 100;
                    this.DA = da;
                    break;
                case double n when n > 5000 & n < 10000:
                    da = (20 * Salary) / 100;
                    this.DA = da;
                    break;
                case double n when n > 10000 & n < 15000:
                    da = (25 * Salary) / 100;
                    this.DA = da;
                    break;
                case double n when n > 15000 & n < 20000:
                    da = (30 * Salary) / 100;
                    this.DA = da;
                    break;
                case double n when n >= 20000:
                    da = (35 * Salary) / 100;
                    this.DA = da;
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }
        public void getda()
        {
            Console.WriteLine("Employee DA is: " + this.DA);
        }
        public void setgs()
        {
            double gs;
            gs = Salary + HRA + TA + DA;
            this.GrossSalary = gs;
        }
        public void getgs()
        {
            Console.WriteLine("Employee GrossSalary is :" + this.GrossSalary);
        }
        public void calculatesalary()
        {
            double pf, tds, ns;
            pf = (10 * GrossSalary) / 100;
            this.PF = pf;
            tds = (18 * GrossSalary) / 100;
            this.TDS = tds;
            ns = GrossSalary - (PF + TDS);
            this.NetSalary = ns;
        }
        public void getcs()
        {
            Console.WriteLine("Employee PF is :" + PF);
            Console.WriteLine("Employee TDS is :" + TDS);
            Console.WriteLine("Employee NetSalary is :" + NetSalary);
        }
    }
}