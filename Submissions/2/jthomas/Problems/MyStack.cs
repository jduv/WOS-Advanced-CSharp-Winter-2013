namespace Problems
{
    using System;
    using System.Collections.Generic;
    public class MyStack<T> : IStack<T>
    {
        #region Fields and Constants
        private IList<T> q = new List<T>();
#endregion  
        #region Properties

        public int Count
        {
            get { return this.q.Count; }

        }
        #endregion

        #region Public Methods

        public void Push(T toPush)
        {
            this.q.Add(toPush);
                     
           
        }

        public T Pop()
        {
          if(this.Count == 0)
          {
              return default(T);
          }
            else
          {
              var toReturn = this.q[this.q.Count - 1];
              this.q.RemoveAt(this.q.Count - 1);
              return toReturn;

          }
        }


        #endregion
    }
}