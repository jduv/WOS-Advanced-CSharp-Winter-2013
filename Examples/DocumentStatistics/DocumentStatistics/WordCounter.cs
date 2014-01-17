
namespace DocumentStatistics
{
    using System;

    public class WordCounter
    {
        #region Fields & Constants

        private string toCount;

        #endregion

        #region Constructors & Destructors

        public WordCounter(string toCount)
        {
            if (toCount == null)
            {
                throw new ArgumentException("String to count cannot be null.");
            }

            this.toCount = toCount;
            this.Words = CountWords(toCount);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of words in the file.
        /// </summary>
        public int Words { get; private set; }

        /// <summary>
        /// The file whose words we counted.
        /// </summary>
        public string ToCount
        {
            get
            {
                return this.toCount;
            }
        }

        #endregion

        #region Private Methods

        private static int CountWords(string toCount)
        {
            int wordCount = 0;
            string prevChar = toCount[0].ToString();
            string currentChar;
            for (int i = 1; i < toCount.Length; i++)
            {
                currentChar = toCount[i].ToString();
                if ((string.IsNullOrWhiteSpace(currentChar) && !string.IsNullOrWhiteSpace(prevChar)) ||
                    !string.IsNullOrWhiteSpace(currentChar) && i == toCount.Length - 1)
                {
                    wordCount++;
                }
                prevChar = currentChar;
            }

            return wordCount;
        }

        #endregion
    }
}
