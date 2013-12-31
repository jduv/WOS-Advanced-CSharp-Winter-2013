namespace DelegateExample
{
    using System;
    using System.Threading;

    /// <summary>
    /// Delegate demonstration class.
    /// </summary>
    public class Timer : ITimer
    {
        #region Fields & Constants

        private int secondsElapsed;
        public DateTime startTime;

        #endregion

        #region Constructors & Destructors

        public Timer()
        {
            this.secondsElapsed = 0;
        }

        #endregion

        #region Delegates & Handlers

        public delegate void SecondChangedHandler(ITimer timer);

        public SecondChangedHandler OnSecondChanged;

        #endregion

        #region Properties

        public int ElapsedSeconds
        {
            get
            {
                return this.secondsElapsed;
            }
        }

        #endregion

        #region Public Methods

        public void Start()
        {
            this.startTime = DateTime.Now;
            while (true)
            {
                Thread.Sleep(100);
                var secondsElapsed = DateTime.Now.Second - this.startTime.Second;
                if (this.secondsElapsed != secondsElapsed)
                {
                    // Fire event
                    this.secondsElapsed = secondsElapsed;
                    this.InvokeSecondChanged();
                }
            }
        }

        #endregion

        #region Private Methods

        private void InvokeSecondChanged()
        {
            if (this.OnSecondChanged != null)
            {
                this.OnSecondChanged(this);
            }
        }

        #endregion
    }
}
