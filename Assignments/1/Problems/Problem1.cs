
namespace Problems
{
    /// <summary>
    /// Implement all of the methods on this class.
    /// </summary>
    public class Problem1
    {
        /// <summary>
        /// Return a *new* point class whose X and Y values are twice those of the input
        /// instance.
        /// </summary>
        /// <param name="pointClass"> 
        /// The input class whose X and Y to double.
        /// </param>
        /// <returns>
        /// A new instance of the point class whose X and Y values are double those of the 
        /// input.
        /// </returns>
        public PointClass ReturnADoubledPointClass(PointClass pointClass)
        {
            var myNewPoint = new PointClass(pointClass.X * 2, pointClass.Y * 2);
            return myNewPoint;
        }

        /// <summary>
        /// Modify the passed in point class such that the X and Y values are twice their
        /// original values. Note that this is called a Side Affecting method, and it's
        /// generally bad practice to write code like this. Nevertheless, it is instructional
        /// to see the difference between structs and reference types. We should be able to
        /// modify the class and have the changes stick--something that's impossible to do with
        /// structs unless we pass the new value out of the method.
        /// </summary>
        /// <param name="pointClass">
        /// The target point class to double.
        /// </param>
        public void DoubleTheTargetPointClass(PointClass pointClass)
        {
            pointClass.X *= 2;
            pointClass.Y *= 2;
        }

        /// <summary>
        /// Return a *new* point struct whose X and Y values are twice those of the input
        /// instance.
        /// </summary>
        /// <param name="pointClass"> 
        /// The input class whose X and Y to double.
        /// </param>
        /// <returns>
        /// A new instance of the point class whose X and Y values are double those of the 
        /// input.
        /// </returns>
        public PointStruct ReturnADoubledPointStruct(PointStruct pointStruct)
        {
            return new PointStruct(pointStruct.X * 2, pointStruct.Y * 2);
        }

        /// <summary>
        /// Modify the passed in point struct and return it such that the X and Y values are twice
        /// their original values. Because we're using structs, we have to let the parameter escape 
        /// the method or our changes will never stick.
        /// </summary>
        /// <param name="pointStruct">
        /// The point struct to modify.
        /// </param>
        /// <returns>
        /// The modified point struct whose X and Y values are double those of the input.
        /// </returns>
        public MutablePointStruct DoubleTheTargetPointStruct(MutablePointStruct pointStruct)
        {
            var myNewStruct = new MutablePointStruct(pointStruct.X * 2, pointStruct.Y * 2);
            return myNewStruct;
        }

        /// <summary>
        /// Find the bug below and fix it.
        /// </summary>
        /// <param name="pointStruct">
        /// A target point struct.
        /// </param>
        /// <returns>
        /// A modified point struct whose X and Y values are twice the original.
        /// </returns>
        public MutablePointStruct FindTheBug(MutablePointStruct pointStruct)
        {
            return new MutablePointStruct(pointStruct.X * 2, pointStruct.Y * 2);
        }
    }
}
