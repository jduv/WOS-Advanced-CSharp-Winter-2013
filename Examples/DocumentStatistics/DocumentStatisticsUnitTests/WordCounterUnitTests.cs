namespace DocumentStatisticsUnitTests
{
    using DocumentStatistics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class WordCounterUnitTests
    {
        [TestMethod]
        public void Prop_Words_ReturnsCorrectCount()
        {
            var target = new WordCounter("Hello my name is jduv");
            Assert.AreEqual(5, target.Words);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Ctor_NullArgumentFails()
        {
            var target = new WordCounter(null);
        }
    }
}
