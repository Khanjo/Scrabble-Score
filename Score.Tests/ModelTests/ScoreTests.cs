using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scores.Models;
using System.Collections.Generic;
using System;

namespace Scores.Tests
{
    [TestClass]
    public class ScoresTests
    {
        [TestMethod]
        public void ScoreConstructor_CreatesInstanceOfScore_Score()
        {
            Score newScore = new Score("hello");
            Assert.AreEqual(typeof(Score), newScore.GetType());
        }
        [TestMethod]
        public void ScoreConstructor_TakesInputAsWord_Score()
        {
            string input = "hello";
            Score newScore = new Score(input);
            Assert.AreEqual(newScore.Word, input);
        }
        [TestMethod]
        public void WordArray_MakesArrayFromWord_Score()
        {
            string input = "hello";
            Score newScore = new Score(input);
            char[] letters = newScore.WordArray();
            Assert.IsInstanceOfType(letters, typeof(Array));
        }
        [TestMethod]
        public void WordScore_ReturnsIntValueForWord_Score()
        {
            char[] letters = { 'c', 'a', 't' };
            int score = letters.WordScore();
            Assert.AreEqual(score, 5);
        }
    }
}