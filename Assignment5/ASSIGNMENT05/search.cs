using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT05
{
    internal class search
    {

        public static void Main()
        {
            
                string sSearch;

                List<employee> listemp = new List<employee>();
                listemp.Add(new employee());
                listemp[0].name = "sid";
                listemp[0].age = 20;
                listemp[0].salary = 15000;



                listemp.Add(new employee());
                listemp[1].name = "nina";
                listemp[1].age = 22;
                listemp[1].salary = 15000;



                listemp.Add(new employee());
                listemp[2].name = "stefan";
                listemp[2].age = 20;
                listemp[2].salary = 15000;

            
                Console.WriteLine("what do you want to find");
                sSearch = Console.ReadLine();

                for (int icount = 0; icount < listemp.Count; icount++)
                {
                    if (listemp[icount].name.Equals(sSearch))
                    {
                        Console.WriteLine("found it");
                        Console.WriteLine(listemp[icount].getData());
                    }

                }  
        }
    }
}
