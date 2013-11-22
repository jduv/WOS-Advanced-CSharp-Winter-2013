using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public struct MutablePointStruct
    {
        #region Fields & Constants

        private double x;
        private double y;

        #endregion

        #region Constructors & Destructors

        public MutablePointStruct(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Properties

        public double X { get { return this.x; } set { this.x = value; } }
        public double Y { get { return this.y; } set { this.y = value; } }

        #endregion
    }
}
