using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class PointClass
    {
        #region Fields & Constants

        private readonly double x;
        private readonly double y;

        #endregion

        #region Constructors & Destructors

        public PointClass(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Properties

        public double X { get { return this.x; } }
        public double Y { get { return this.y; } }

        #endregion
    }
}
