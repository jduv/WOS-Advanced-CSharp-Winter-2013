namespace DelegateExample
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer();
            timer.OnSecondChanged += OddSecondHandler;
            timer.OnSecondChanged += EvenSecondHandler;
            timer.Start();
        }

        public static void OddSecondHandler(ITimer toHandle)
        {
            if (toHandle.ElapsedSeconds % 2 == 0)
            {
                var msg = string.Format("{0} seconds have passed, which is even.", toHandle.ElapsedSeconds);
                Console.WriteLine(msg);
            }
        }

        public static void EvenSecondHandler(ITimer toHandle)
        {
            if (toHandle.ElapsedSeconds % 2 != 0)
            {
                var msg = string.Format("{0} seconds have passed, which is odd.", toHandle.ElapsedSeconds);
                Console.WriteLine(msg);
            }
        }
    }
}
