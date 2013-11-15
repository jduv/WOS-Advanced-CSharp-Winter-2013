using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class MyCoolCarTester
    {
        static void Main(string[] args)
        {
            try
            {
                ICar myCar = new Car();
                myCar.Move(Direction.EAST, 2);
                Console.WriteLine("Hey.");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Caught Exception");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
