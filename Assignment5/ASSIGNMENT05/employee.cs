using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT05
{
    internal class employee
    {
        public int id;
        public string name;
        public int age;
        public int salary;

        public string getData()
        {
            return "employee " + this.name + " is of " + this.age + " years old and has salary " + this.salary ;
        }
    }
}
