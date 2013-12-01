namespace Problems
{
    /// <summary>
    /// Represents any object that is countable.
    /// </summary>
    public interface ICountable
    {
        #region Properties

        /// <summary>
        /// Gets the total number of items inside the object.
        /// </summary>
        int Count { get; }

        #endregion
    }
}
