using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable]
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

        public double _GrossSalary
        {
            get
            {
                return GrossSalary;
            }
            set
            {
                GrossSalary = value;
            }
        }

        public double _Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }

        public double _PF
        {
            get
            {
                return PF;
            }
            set
            {
                PF = value;
            }
        }

        public double _TDS
        {
            get
            {
                return TDS;
            }
            set
            {
                TDS = value;
            }
        }

        public double _NetSalary
        {
            get
            {
                return NetSalary;
            }
            set
            {
                NetSalary = value;
            }
        }


        public void setEmpDetails(int EmpNo, string EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }
        public void getEmpDetails()
        {
            Console.WriteLine("Employee Number is: " + this.EmpNo);
            Console.WriteLine("Employee Name is: " + this.EmpName);
            Console.WriteLine("Employee Salary is: " + this.Salary);
        }


        public double setHRA(double HRA)
        {

            if (Salary > 0 & Salary < 5000)
            {
                HRA = (10 * Salary) / 100;
                return this.HRA = HRA;
            }
            else if (Salary > 5000 & Salary < 10000)
            {
                HRA = (15 * Salary) / 100;
                return this.HRA = HRA;
            }
            else if (Salary > 10000 & Salary < 15000)
            {
                HRA = (20 * Salary) / 100;
                return this.HRA = HRA;
            }
            else if (Salary > 15000 & Salary < 20000)
            {
                HRA = (25 * Salary) / 100;
                return this.HRA = HRA;
            }
            else
            {
                HRA = (30 * Salary) / 100;
                return this.HRA = HRA;
            }

        }

        public double setTA(double TA)
        {
            this.TA = TA;

            if (Salary < 5000)
            {
                TA = (5 * Salary) / 100;
                return this.TA = TA;
            }
            else if (Salary < 10000)
            {
                TA = (10 * Salary) / 100;
                return this.TA = TA;
            }
            else if (Salary < 15000)
            {
                TA = (15 * Salary) / 100;
                return this.TA = TA;
            }
            else if (Salary < 20000)
            {
                TA = (20 * Salary) / 100;
                return this.TA = TA;
            }
            else
            {
                TA = (25 * Salary) / 100;
                return this.TA = TA;
            }
        }

        public double setDA(double DA)
        {
            this.DA = DA;

            if (Salary < 5000)
            {
                DA = (15 * Salary) / 100;
                return this.DA = DA;
            }
            else if (Salary < 10000)
            {
                DA = (20 * Salary) / 100;
                return this.DA = DA;
            }
            else if (Salary < 15000)
            {
                DA = (25 * Salary) / 100;
                return this.DA = DA;
            }
            else if (Salary < 20000)
            {
                DA = (30 * Salary) / 100;
                return this.DA = DA;
            }
            else
            {
                DA = (35 * Salary) / 100;
                return this.DA = DA;
            }
        }

        public double getGrossSalary(double Salary, double HRA, double TA, double DA)
        {
            this.GrossSalary = Salary + HRA + TA + DA;
            return this.GrossSalary;
        }

        public virtual void CalculateSalary(double GrossSalary)
        {
            this.PF = (10 * GrossSalary) / 100;
            this.TDS = (18 * GrossSalary) / 100;
            this.NetSalary = GrossSalary - (this.PF + this.TDS);
        }



        public void showSalary()
        {
            Console.WriteLine("Your PF is: {0}", this.PF);
            Console.WriteLine("Your TDS is: {0}", this.TDS);
            Console.WriteLine("Your NetSalary is: {0}", this.NetSalary);
        }

    }

    //Manager

    public class Manager : Employee
    {
        double Petrol_Allowance;
        double Food_Allowance;
        double Other_Allowance;

        public double setPetrol(double _Salary)
        {
            this.Petrol_Allowance = (8 * _Salary) / 100;
            return this.Petrol_Allowance;
        }

        public double setFood(double _Salary)
        {

            this.Food_Allowance = (13 * _Salary) / 100;
            return this.Food_Allowance;
        }

        public double setOther(double _Salary)
        {
            this.Other_Allowance = (3 * _Salary) / 100;
            return this.Other_Allowance;
        }


        public virtual double setAllowance(double Petrol_Allowance, double Food_Allowance, double Other_Allowance)
        {
            this._GrossSalary = Petrol_Allowance + Food_Allowance + Other_Allowance;
            return this._GrossSalary;
        }

        public override void CalculateSalary(double GrossSalary)
        {

            this._PF = (10 * GrossSalary) / 100;
            this._TDS = (18 * _GrossSalary) / 100;
            this._NetSalary = _GrossSalary - (this._PF + this._TDS);

        }

        public void showSalary()
        {
            Console.WriteLine("Your PF is: {0}", this._PF);
            Console.WriteLine("Your TDS is: {0}", this._TDS);
            Console.WriteLine("Your NetSalary is: {0}", this._NetSalary);
        }
    }

    //MarketingExecutive
    public class MarketingExecutive : Manager
    {
        private double Kilometer_travel;
        private double Tour_Allowance = 5;
        private double Telephone_Allowance = 1000;

        public double setTravel(double Kilometer_travel)
        {
            return this.Kilometer_travel = Kilometer_travel;
        }

        public void getTravel()
        {
            Console.WriteLine("You traveled for : " + Kilometer_travel + " kms");
        }

        public double getTour(double Tour_Allowance)
        {
            this.Tour_Allowance = 5 * this.Kilometer_travel;
            return this.Tour_Allowance;
        }

        public double setTour(double Tour_Allowance)
        {
            this.Tour_Allowance = 5 * this.Kilometer_travel;
            return this.Tour_Allowance;
        }

        public void getTour()
        {
            Console.WriteLine("Tour Allowance per km is: Rs.{0}", this.Tour_Allowance);
        }

        public double setTelephone()
        {
            return this.Telephone_Allowance = 1000;

        }

        public override double setAllowance(double Kilometer_travel, double Tour_Allowance, double Telephone_Allowance)
        {
            this._GrossSalary = Tour_Allowance + Telephone_Allowance;
            return this._GrossSalary;
        }

        public override void CalculateSalary(double GrossSalary)
        {

            this._PF = (10 * GrossSalary) / 100;
            this._TDS = (18 * GrossSalary) / 100;
            this._NetSalary = GrossSalary - (this._PF + this._TDS);

        }

        public void showSalary()
        {
            Console.WriteLine("Your PF is: {0}", this._PF);
            Console.WriteLine("Your TDS is: {0}", this._TDS);
            Console.WriteLine("Your NetSalary is: {0}", this._NetSalary);
        }
    }


}
