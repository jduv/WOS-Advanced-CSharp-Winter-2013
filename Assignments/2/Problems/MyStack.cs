using System.Collections.Generic;
namespace Problems
{
    public class MyStack<T> : IStack<T>
    {
        #region Fields & Constants

        private IList<T> backingList = new List<T>();

        #endregion

        #region Properties

        public int Count
        {
            get { return this.backingList.Count; }
        }

        #endregion

        #region Public Methods

        public void Push(T toPush)
        {
            this.backingList.Add(toPush);
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                return default(T);
            }
            else
            {
                var toReturn = this.backingList[this.backingList.Count - 1];
                this.backingList.RemoveAt(this.backingList.Count - 1);
                return toReturn;
            }
        }

        #endregion
    }
}