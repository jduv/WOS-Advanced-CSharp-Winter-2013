namespace Problems
{
    using System;

    /// <summary>
    /// Complete the methods below given the specifications in the comments.
    /// </summary>
    public class Problem1
    {
        #region Public Methods

        /// <summary>
        /// This method should simply tell the user if the number a is divisible by the number b.
        /// For example, if a = 1 and b = 2, then that equals 1/2, so it should return false. However,
        /// if a = 2 and b = 2, then that equals 2/2 = 1, so it should return true. Other examples:
        /// 
        /// 1. a = 3, b = 2, 3/2 = false.
        /// 2. a = 6, b = 3, 6/3 = true.
        /// 3. a = 7, b = 1, 7/1 = true.
        /// 4. a = 0, b = 9, 0/9 = true.
        /// 6. a = 8, b = 0, 8/0 = throw exception (b is zero).
        /// 7. a = -7, b = 8, -7/8 = throw exception (a is negative).
        /// 8. a = 7, b = -8, 7/-8 = throw exception (b is negative).
        /// 
        /// Hint: use the magical modulo operator (%). If either a or b is negative, this method should
        /// throw an ArgumentException. If b is zero, this method should throw an argument exception.
        /// </summary>
        /// <param name="a">
        /// The numerator to test. Must be positive.
        /// </param>
        /// <param name="b">
        /// The denominator. Must be positive.
        /// </param>
        /// <returns>
        /// True if b divides evenly into a, false otherwise.
        /// </returns>
        public bool IsDivisibleBy(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method should sum the first N integers. So, if the parameter passed to the 
        /// method is 5, then it should return 1 + 2 + 3 + 4 + 5 = 15. If this method is passed
        /// a negative value, it will throw an ArgumentException. If this method is passed zero,
        /// it should return zero.
        /// </summary>
        /// <param name="n">
        /// The value to sum up to.
        /// </param>
        /// <returns>
        /// The sum of numbers from 1 to n.
        /// </returns>
        public int Sum(int n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A palindrome is a sentence or string that's the exact same forwards and backwards. For example, the
        /// string xxyxx is a palindrome. It begins with two X's, has a y in the middle, then ends with two X's.
        /// It reads the same either way. This method should take in a string and return true if that string is
        /// detected to be a palindrome, or false otherwise. Some scehmatics:
        /// 
        /// 1. If null is passed, this method should throw an ArgumentNullException.
        /// 2. If the empty string, that is "" or string.Empty is passed, it should return true. The empty
        ///    string can be considered a palindrome.
        /// 3. This method should ignore case and white space--but don't worry about punctuation. For example,
        ///    if "x X y x X is" passed, then it should return true. However, if "x,x,y,x,x" is passed, it's not. 
        ///    Ignoring puncutation will greatly simplify the problem.
        ///    
        /// Hint: Thing about how a palindrome is basically the same thing forwards and backwards. You can access a
        /// string just as if it were an array of characters. So, if you had the string toCheck = xxyxxx then you could
        /// use toCheck[0] = x, and compare that with toCheck[4] = x, then decrement both counters and so forth.
        /// </summary>
        /// <param name="toCheck">
        /// The string to check.
        /// </param>
        /// <returns>
        /// True if the target string is a palindrome, false otherwise.
        /// </returns>
        public bool IsPalindrome(string toCheck)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}
