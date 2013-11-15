using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public enum Direction
    {
        NORTH, EAST, SOUTH, WEST
    }

    public class Car : ICar, IEquatable<Car>
    {
        public void Move(Direction direction, int velocity)
        {
            switch (direction)
            {
                case Direction.NORTH:
                    Console.WriteLine("Moving north by " + velocity + " units");
                    break;
                case Direction.SOUTH:
                    Console.WriteLine("Moving south by " + velocity + " units");
                    break;
                case Direction.WEST:
                    Console.WriteLine("Moving west by " + velocity + " units");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void Lock(double latitude, double longitude)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Car other)
        {
            throw new NotImplementedException();
        }
    }
}
