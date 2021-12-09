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

    }
}



