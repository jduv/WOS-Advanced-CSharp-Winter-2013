namespace Problems
{
    using System;

    /// <summary>
    /// Represents a point.
    /// </summary>
    public class Point : IEquatable<Point>
    {
        #region Constructors & Destructors

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The X coordinate.
        /// </summary>
        public double X { get; private set; }

        /// <summary>
        /// The Y coordinate
        /// </summary>
        public double Y { get; private set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a random point. X and Y are unbounded, but will always remain positive.
        /// </summary>
        /// <returns>
        /// A point where the X and Y are randomly generated
        /// </returns>
        public static Point CreateRandomPositivePoint()
        {
            var rand = new Random();
            return new Point(rand.NextDouble() * rand.Next(), rand.NextDouble() * rand.Next());
        }

        /// <summary>
        /// Checks to see if the target passed in point is numerically equal to this one.
        /// </summary>
        /// <param name="other">
        /// The other point to test.
        /// </param>
        /// <returns>
        /// True if the points are equal, false otherwise. This checks only for a numeric
        /// equality, not for reference equality.
        /// </returns>
        public bool Equals(Point other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        #endregion
    }
}
