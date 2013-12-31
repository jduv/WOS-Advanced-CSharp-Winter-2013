namespace Problems
{
    /// <summary>
    /// Represents a Queue data structure. A Queue is a "first in first out"
    /// data structure.
    /// </summary>
    /// <typeparam name="T">
    /// The type of items that the Queue holds.
    /// </typeparam>
    public interface IQueue<T> : ICountable
    {
        #region Methods

        /// <summary>
        /// Adds an item to the top of the Queue.
        /// </summary>
        /// <param name="toQueue">The item to put into the Q</param>
        void Enqueue(T toQueue);

        /// <summary>
        /// Gets the first item on the Queue and returns it. If the queue is empty, it should return the
        /// default value for the type it's holding.
        /// </summary>
        /// <returns>
        /// The removed item.
        /// </returns>
        T Dequeue();

        #endregion
    }
}
