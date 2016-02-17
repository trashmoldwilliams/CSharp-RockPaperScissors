using System.Collections.Generic;
using System;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    private string _input1;
    private string _input2;

    public Game(string myInput1, string myInput2)
    {
      _input1 = myInput1;
      _input2 = myInput2;
    }

    public string GetResults()
    {
      if(_input1 == _input2)
      {
        return "tie";
      }
      else if(_input1 == "paper" && _input2 == "rock")
      {
        return "Player 1";
      }
      else if(_input1 == "paper" && _input2 == "scissors")
      {
        return "Player 2";
      }
      else if(_input1 == "rock" && _input2 == "scissors")
      {
        return "Player 1";
      }
      else if(_input1 == "rock" && _input2 == "paper")
      {
        return "Player 2";
      }
      else if(_input1 == "scissors" && _input2 == "paper")
      {
        return "Player 1";
      }
      else
      {
        return "Player 2";
      }
    }
  }
}
