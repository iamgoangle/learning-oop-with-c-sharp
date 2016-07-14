using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_oop
{
    class variable
    {
        public int squareVal(int valParam)
        {
            return valParam *= valParam;
        }

        public int squareRef(ref int valRef)
        {
            return valRef *= valRef;
        }
    }
    class test : variable
    {
        static void Main(string[] args)
        {
            int arg;
            arg = 4;

            // example passing by value, not binding to source variable.
            // just a copy value to parameter
            variable valRef = new variable();
            valRef.squareVal(arg);
            System.Console.WriteLine(arg);

            // example passing by reference is binding value to source varialble.
            // when the function has changed value to variable it will affect to variable.
            variable passRef = new variable();
            passRef.squareRef(ref arg);
            System.Console.WriteLine(arg);


            System.Console.ReadLine();
        }
    }
}
