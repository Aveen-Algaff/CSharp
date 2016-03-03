using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
   public class Employee
    {
        public string FirstName { get; internal set; }
        public int ID { get; internal set; }
        private string _FirstName;
        private string _LastName;

        private string _Ssd;
        private string _Wage;

        //Constructors

        public Employee(string FirstName, string LastName, string Ssd, string Wage)
        {
          this. _FirstName = FirstName;
          this. _LastName = LastName;
          this. _Ssd = Ssd;
          this. _Wage = Wage;
        }

        

        // method och return 
        public string method ()
        {

          return   _FirstName +_LastName +_Ssd +_Wage;
        }
        

        }











    }

