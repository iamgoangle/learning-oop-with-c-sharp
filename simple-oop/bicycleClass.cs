using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_oop
{
    class bicycleClass : baseVehicleClass
    {
        static void Main(string[] args)
        {
            bicycleClass merida = new bicycleClass();
            merida.model = "Reacto 400";
            merida.price = 45000;

            System.Console.WriteLine(merida.model);
            System.Console.WriteLine(merida.price);
            System.Console.WriteLine(merida.testDrive());
            System.Console.ReadLine();
        }
    }
}
