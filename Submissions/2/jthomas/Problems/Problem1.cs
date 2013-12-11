namespace Problems
{
    using System;

    
    public class Problem1
    {
        #region Public Methods

       
        public bool IsDivisibleBy(int a, int b)
        {
            if (a < 0) throw new ArgumentException();
            if (b==0) throw new ArgumentException();
            if (a % b== 0) throw new ArgumentException();

             else return false;

        }

        
        public int Sum(int n)
        {
      

            while (n > 0)
              {
                Sum(n);

            }
                if (n < 0) throw new ArgumentException();
                else if (n == 0)
                {
                    return 0;
                }
                else
                    return Sum(n);


            }
            
            
        

        public bool IsPalindrome(string toCheck)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}