
using System;
using System.Collections.Generic;
namespace DocumentStatistics
{
    public class CommonWordCounter
    {
        #region Fields & Constants

        private readonly string toCount;

        #endregion

        #region Constructors & Destructors

        public CommonWordCounter(string toCount)
        {
            if (toCount == null)
            {
                throw new ArgumentException("String to count cannot be null.");
            }

            this.toCount = toCount;
            this.WordDictionary = FindCommonWords(toCount);
        }

        #endregion

        #region Properties

        public IDictionary<string, int> WordDictionary { get; private set; }

        #endregion

        #region Public Methods

        public string PrintWords()
        {
            return null;
        }

        #endregion

        #region Private Methods

        private static IDictionary<string, int> FindCommonWords(string toCount)
        {
            var wordDictionary = new Dictionary<string, int>();

            string prevChar = toCount[0].ToString();
            string currentChar;
            string word;
            int lastSpaceIndex = 0;

            for (int i = 1; i < toCount.Length; i++)
            {
                currentChar = toCount[i].ToString();
                if ((string.IsNullOrWhiteSpace(currentChar) && !string.IsNullOrWhiteSpace(prevChar)) ||
                    !string.IsNullOrWhiteSpace(currentChar) && i == toCount.Length - 1)
                {
                    if (i == toCount.Length - 1)
                    {
                        i++;
                    }

                    word = StripPunctuation(toCount.Substring(lastSpaceIndex, i - lastSpaceIndex));

                    if (!wordDictionary.ContainsKey(word))
                    {
                        wordDictionary.Add(word, 0);
                    }

                    wordDictionary[word]++;
                    lastSpaceIndex = i + 1;
                }
                prevChar = currentChar;
            }

            return wordDictionary;
        }

        private static string StripPunctuation(string toStrip)
        {
            string stripped = "";
            foreach (var character in toStrip)
            {
                if (IsValidCharacter(character))
                {
                    stripped += character;
                }
            }

            return stripped;
        }

        private static bool IsValidCharacter(char toCheck)
        {
            return char.IsLetter(toCheck) || "'".Equals(toCheck.ToString()) || char.IsDigit(toCheck) || "-".Equals(toCheck.ToString());
        }

        #endregion

    }
}
