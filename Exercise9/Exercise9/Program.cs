using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter choice:");
            //Console.WriteLine("1. Add employee:");
            //Console.WriteLine("2.Remove employee:");
            //Console.WriteLine("3. Print entire registry:");
            //Console.WriteLine("4. Exit:");
            List<Employee> employees = new List<Employee>();
            var employee1 = new Employee("Aveen","Algaff","1981","25000");
            employees.Add(employee1);
            employees.Add(new Employee("Aveen", "Algaff", "1981", "25000"));
            employees.Add(new Employee("Aveen","Algaff","1981","25000") { ID = 124 });   // object initializer, överkurs

            // remove from list in foreach must be done in two steps to not "destroy" iteration
            //var removeList = new List<Employee>();
            foreach (var item in employees)
            {
                Console.WriteLine("Name: " + item.method());

                //if (item.FirstName == "Aveen")
                //    removeList.Add(item);
            }

            //foreach (var item in removeList)
            //    employees.Remove(item);
            //Console.ReadKey();

        }
    }
}
