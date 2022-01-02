using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace WordCount.Tests
{
    [TestClass]
    public class CountToolsTest
    {
        private List<string> _lines = new List<string>
        {
            "Poor naked wretches, wheresoe'er you are,",
            "That bide the pelting of this pitiless storm,",
            "How shall your houseless heads and unfed sides,",
            "Your loop'd and window'd raggedness, defend you",
            "From seasons such as these?  O, I have ta'en",
            "Too little care of this!"
        };

        [TestMethod]
        public void LineCount_GivenText_ShouldReturn6()
        {
            // Act
            var lineCount = CountTools.LineCount(_lines);

            // Assert
            Assert.AreEqual(6, lineCount);
        }

        [TestMethod]
        public void WordCount_GivenText_ShouldReturn47()
        {
            // Act
            var wordCount = CountTools.WordCount(_lines);

            // Assert
            Assert.AreEqual(47, wordCount);
        }

        [TestMethod]
        public void CharCount_GivenText_ShouldReturn248()
        {
            // Act
            var charCount = CountTools.CharCount(_lines);

            // Assert
            Assert.AreEqual(248, charCount);
        }
    }
}
