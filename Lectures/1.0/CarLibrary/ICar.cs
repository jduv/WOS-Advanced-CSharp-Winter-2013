using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public interface ICar
    {
        void Move(Direction direction, int velocity);
        void Lock(double latitude, double longitude);
    }
}
