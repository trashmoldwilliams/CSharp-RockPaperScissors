using System.Collections.Generic;
using Xunit;
namespace RockPaperScissors.Objects
{
  public class RockPaperScissorsTest
  {
    [Fact]
    public void Test1_IfInput1EqualsInput2_ReturnTie()
    {
      //Arrange
      string input1 = "rock";
      string input2 = "rock";
      Game testGame = new Game(input1, input2);

      //Act
      string result = testGame.GetResults();

      //Assert
      Assert.Equal("tie", result);
    }
    [Fact]
    public void Test2_IfInput1IsPaperAndInput2IsRock_ReturnPlayer1()
    {
      //Arrange
      string input1 = "paper";
      string input2 = "rock";
      Game testGame = new Game(input1, input2);

      //Act
      string result = testGame.GetResults();

      //Assert
      Assert.Equal("Player 1", result);
    }
    [Fact]
    public void Test3_IfInput1IsRockAndInput2IsPaper_ReturnPlayer2()
    {
      //Arrange
      string input1 = "rock";
      string input2 = "paper";
      Game testGame = new Game(input1, input2);

      //Act
      string result = testGame.GetResults();

      //Assert
      Assert.Equal("Player 2", result);
    }
  }
}
