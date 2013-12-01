namespace Problems
{
    /// <summary>
    /// Represents a stack data structure. A stack is a "last in first out"
    /// data structure.
    /// </summary>
    /// <typeparam name="T">
    /// The type of items that the stack holds.
    /// </typeparam>
    public interface IStack<T> : ICountable
    {
        #region Methods

        /// <summary>
        /// Pushes the target item onto the top of the stack.
        /// </summary>
        /// <param name="toPush">
        /// The item to push.
        /// </param>
        void Push(T toPush);

        /// <summary>
        /// Removes the last item added to the stack and returns it.
        /// </summary>
        /// <returns></returns>
        T Pop();

        #endregion
    }
}
