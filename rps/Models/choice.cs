namespace RockPaperScissors
{

  public class RPSGame
  {
    public string _playerOne { get; }
    public string _playerTwo { get; }

    public RPSGame(string playerOneMove, string playerTwoMove)
    {
      _playerOne = playerOneMove.ToLower();
      _playerTwo = playerTwoMove.ToLower();
    }

    public string GameOutcome()
    {
      if (_playerOne == _playerTwo)
      {
        return "It's a draw!";
      }
      else if ((_playerOne == "rock" && _playerTwo == "scissors") || (_playerOne == "paper" && _playerTwo == "rock") || (_playerOne == "scissors" && _playerTwo == "paper"))
      {
        return "Player One wins this round!";
      }
      else
      {
        return "Player Two wins this round!";
      }
    }
  }
}