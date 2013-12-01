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
        /// <param name="toQueue"></param>
        void Enqueue(T toQueue);

        /// <summary>
        /// Removes the first item on the Queue and removes it.
        /// </summary>
        /// <returns>
        /// The removed item.
        /// </returns>
        T Dequeue();

        #endregion
    }
}
