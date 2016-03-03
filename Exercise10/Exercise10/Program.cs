using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var MyVehicle = new VehicleData();
           
            var myVehicle = new Car();
                // Setting Values
            myVehicle.Model = "XC90";
            myVehicle.Manufacturar = "Volvo";
            myVehicle.RegNumber = "XYZ123";            
            

            //-----------------------------------
            
            var myVehicler2 = new Car();

            // Setting Values2
            myVehicler2.Model = "i520";
            myVehicler2.Manufacturar = "BMW";
            myVehicler2.RegNumber = "ABC456";
            MyVehicle.PrintVehicle(myVehicle );
            
        }
    }
    
}
