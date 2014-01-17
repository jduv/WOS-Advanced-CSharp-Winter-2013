
using DocumentStatistics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DocumentStatisticsUnitTests
{
    [TestClass]
    public class CommonWordCounterUnitTests
    {
        private static readonly string FiveWordsAllSame = "the the the the the";
        private static readonly string PunctuationTest = "It is rather a singular instance of the manner in which similar views arise at " +
            "about the same time, that Goethe in Germany, Dr. Darwin in England, and Geoffroy Saint-Hilaire (as we shall immediately see) in France, " +
            "came to the same conclusion on the origin of species, in the years 1794-5.)";

        [TestMethod]
        public void Prop_WordDictionary_ReturnsCorrectCount()
        {
            var target = new CommonWordCounter(FiveWordsAllSame);
            Assert.AreEqual(1, target.WordDictionary.Count);
            Assert.AreEqual(5, target.WordDictionary["the"]);

            target = new CommonWordCounter(PunctuationTest);
            var count = target.WordDictionary.Count;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Ctor_NullArgumentFails()
        {
            var target = new CommonWordCounter(null);
        }
    }
}
