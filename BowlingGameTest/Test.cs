//Harsh Patel
//Bowling Game Kata

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class Test
    {
        private Game game;
        [TestInitialize]
        public void Initialize()
        {
            game = new Game();
        }

        [TestMethod]
        public void RollGutter()
        {
            MoreRolls(0, 20);
            Assert.AreEqual(0, game.score);
        }

        private void MoreRolls(int pins, int rolls)
        {
            for (var i = 0; i < rolls; i++)
                game.roll(pins);
        }

        [TestMethod]
        public void RollOnes()
        {
            MoreRolls(1, 20);
            Assert.AreEqual(20, game.score);
        }

        [TestMethod]
        public void RollSpare()
        {
            game.roll(5);
            game.roll(5);
            game.roll(4);
            MoreRolls(0, 17);
            Assert.AreEqual(18, game.score);
        }

        [TestMethod]
        public void RollStrike()
        {
            game.roll(10);
            game.roll(3);
            game.roll(4);
            MoreRolls(0, 16);
            Assert.AreEqual(24, game.score);
        }

        [TestMethod]
        public void CorrectRole()
        {
            MoreRolls(10, 12);
            Assert.AreEqual(300, game.score);
        }
    }
}
