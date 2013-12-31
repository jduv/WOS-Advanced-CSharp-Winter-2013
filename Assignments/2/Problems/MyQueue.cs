namespace Problems
{
    using System.Collections.Generic;

    public class MyQueue<T> : IQueue<T>
    {
        #region Fields & Constants

        private readonly IList<T> backingList = new List<T>();

        #endregion

        #region Properties

        public int Count
        {
            get
            {
                return this.backingList.Count;
            }
        }

        #endregion

        #region Public Methods

        public void Enqueue(T toQueue)
        {
            this.backingList.Add(toQueue);
        }

        public T Dequeue()
        {

            if (this.Count == 0)
            {
                return default(T);
            }
            else
            {
                var toReturn = this.backingList[0];
                this.backingList.RemoveAt(0);
                return toReturn;

            }
        }

        #endregion
    }
}
