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
            Score newScore = new Score();
            Assert.AreEqual(typeof(Score), newScore.GetType());
        }
    }
}