namespace DocumentStatisticsUnitTests
{
    using DocumentStatistics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordCounterUnitTests
    {
        [TestMethod]
        public void Prop_Words_ReturnsCorrectCount()
        {
            var target = new WordCounter("Hello my name is jduv");
            Assert.AreEqual(5, target.Words);
        }
    }
}
