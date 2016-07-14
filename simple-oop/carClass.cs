using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_oop
{
    class carClass : baseVehicleClass
    {
        public override string testDrive()
        {
            //return base.testDrive();
            return "Car driving by wheel";
        }

       /* static void Main(string[] args)
        {
            // create object 'benz'
            carClass benz = new carClass();
            benz.model = "E Class";
            benz.price = 1000;

            // create object 'bmw'
            carClass bmw = new carClass();
            bmw.model = "Series 7";
            bmw.price = 2000;

            System.Console.WriteLine("Benz model is: " + benz.model);
            System.Console.WriteLine("BMW model is: " + bmw.model);

            System.Console.WriteLine("Benz test drive: " + bmw.testDrive());
            System.Console.WriteLine("BMW test drive: " + bmw.testDrive());

            System.Console.ReadLine();
        }*/
    }
}
