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
      RPSGame newGame = new RPSGame("test", "test");
      Assert.AreEqual(typeof(RPSGame), newGame.GetType());
    }

    [TestMethod]

    public void RPSGame_ReturnUserInputtedValueForPlayer1_String()
    {
      //Arrange
      string playerOneMove = "rock";
      RPSGame newGame = new RPSGame(playerOneMove, "paper");
      
      //Act
      string result = newGame._playerOne;

      //Assert
      Assert.AreEqual(playerOneMove, result);
    }

    [TestMethod]

    public void RPSGame_ReturnUserInputtedValueForPlayer2_String()
    {
      //Arrange
      string playerTwoMove = "paper";
      RPSGame newGame = new RPSGame("rock", playerTwoMove);
      
      //Act
      string result = newGame._playerTwo;

      //Assert
      Assert.AreEqual(playerTwoMove, result);
    }

    [TestMethod]

    public void RPSGame_ReturnUserInputtedValueForPlayer1AndPlayer2_String()
    {
      //Arrange
      string playerOneMove = "rock";
      string playerTwoMove = "paper";
      RPSGame newGame = new RPSGame(playerOneMove, playerTwoMove);
      
      //Act
      string resultOne = newGame._playerOne;
      string resultTwo = newGame._playerTwo;

      //Assert
      Assert.AreEqual(playerOneMove, resultOne);
      Assert.AreEqual(playerTwoMove, resultTwo);
    }

    [TestMethod]

    public void RPSGame_DetermineGameIsATieIfPlayerOneEqualsPlayerTwo_String()
    {
      //Arrange
      string playerOneMove = "rock";
      string playerTwoMove = "rock";
      
      //Act
      RPSGame newGame = new RPSGame(playerOneMove, playerTwoMove);

      //Assert
      Assert.AreEqual("It's a draw!", newGame.GameOutcome());
    }

    [TestMethod]

    public void RPSGame_DetermineWinnerAsPlayerOneRockAndPlayerTwoScissors_String()
    {
      //Arrange
      string playerOneMove = "rock";
      string playerTwoMove = "scissors";
      
      //Act
      RPSGame newGame = new RPSGame(playerOneMove, playerTwoMove);

      //Assert
      Assert.AreEqual("Player One wins this round!", newGame.GameOutcome());
    }

    [TestMethod]

    public void RPSGame_DetermineWinnerAsPlayerOnePaperAndPlayerTwoRock_String()
    {
      //Arrange
      string playerOneMove = "paper";
      string playerTwoMove = "rock";
      
      //Act
      RPSGame newGame = new RPSGame(playerOneMove, playerTwoMove);

      //Assert
      Assert.AreEqual("Player One wins this round!", newGame.GameOutcome());
    }

    [TestMethod]

    public void RPSGame_DetermineWinnerAsPlayerOneScissorsAndPlayerTwoPaper_String()
    {
      //Arrange
      string playerOneMove = "scissors";
      string playerTwoMove = "paper";
      
      //Act
      RPSGame newGame = new RPSGame(playerOneMove, playerTwoMove);

      //Assert
      Assert.AreEqual("Player One wins this round!", newGame.GameOutcome());
    }

    [TestMethod]

    public void RPSGame_DetermineWinnerAsPlayerTwoRockAndPlayerOneScissors_String()
    {
      //Arrange
      string playerOneMove = "scissors";
      string playerTwoMove = "rock";
      
      //Act
      RPSGame newGame = new RPSGame(playerOneMove, playerTwoMove);

      //Assert
      Assert.AreEqual("Player Two wins this round!", newGame.GameOutcome());
    }

    [TestMethod]

    public void RPSGame_DetermineWinnerAsPlayerTwoPaperAndPlayerOneRock_String()
    {
      //Arrange
      string playerOneMove = "rock";
      string playerTwoMove = "paper";
      
      //Act
      RPSGame newGame = new RPSGame(playerOneMove, playerTwoMove);

      //Assert
      Assert.AreEqual("Player Two wins this round!", newGame.GameOutcome());
    }

    [TestMethod]

    public void RPSGame_DetermineWinnerAsPlayerTwoScissorsAndPlayerOnePaper_String()
    {
      //Arrange
      string playerOneMove = "paper";
      string playerTwoMove = "scissors";
      
      //Act
      RPSGame newGame = new RPSGame(playerOneMove, playerTwoMove);

      //Assert
      Assert.AreEqual("Player Two wins this round!", newGame.GameOutcome());
    }

    [TestMethod]

    public void RPSGame_MakeAllInputsLowerCase_String()
    {
      //Arrange
      string playerOneMove = "PAPER";
      string playerTwoMove = "paper";

      //Act
      RPSGame newGame = new RPSGame(playerOneMove, playerTwoMove);
      string resultOne = newGame._playerOne;
      string resultTwo = newGame._playerTwo;

      //Assert
      Assert.AreEqual(resultOne, playerTwoMove);
    }
  }
}



