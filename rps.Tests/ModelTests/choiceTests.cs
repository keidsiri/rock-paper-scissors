using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RPSGameTest.Tests
{
  [TestClass]
  public class RPSTest
    {
      [TestMethod]

      public void RPSGame_CreateInstanceOfRpsGame_Item()
      {
        RPSGame newGame = new RPSGame();
        Assert.AreEqual(typeof(RPSGame), newGame.GetType());
      }

      [TestMethod]

      public void RPSGame_ReturnUserInputtedValueForPlayer1_String()
      {
        //Arrange
        // string playerOneMove = "rock";
        RPSGame newGame = new RPSGameStart("test");
        // string result = newGame._playerOne;
        Assert.AreEqual(typeof(RPSGame), newGame.GetType());
      }

    }
}




