using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_oop
{
    class baseVehicleClass
    {
        // defines class member
        public string model {
            get;
            set;
        }

        public string serial {
            get;
            set;
        }

        public int price {
            get;
            set;
        }
        
        // defines class method
        public void simpleMothod()
        {
            System.Console.WriteLine("Welcome...");
        }
        
        // allows sub-class overide method
        public virtual string testDrive()
        {
            return "Automatic change gear and safety.";
        }
    }
}
