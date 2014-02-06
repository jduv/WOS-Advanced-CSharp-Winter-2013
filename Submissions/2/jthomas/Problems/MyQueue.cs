using System.Collections.Generic;
namespace Problems
{
    
    public class MyQueue<T> : IQueue<T>
    {

        #region Fields and Constants

        private readonly IList<T> q = new List<T>();

        #region Properties

        public int Count
        {
            get 
            {
                return this.q.Count;

            }
        }

        #endregion

        #region Public Methods

        public void Enqueue(T toQueue)
        {
            this.q.Add(toQueue);

        }

        public T Dequeue()
        {
            

            if(this.Count == 0)
            {
                return default(T);

            }
            else
            {
                var toReturn = this.q[0];
                this.q.RemoveAt(0);
                return toReturn;
            }
            

        }

        #endregion
    }
}
        #endregion
