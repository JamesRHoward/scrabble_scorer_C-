using Xunit;
using ScrabbleScore.Objects;

namespace ScrabbleTest
{
  public class WhatScrabbleScoreTest
  {
    [Theory]
    [InlineData("c")]
    public void ScrabbleScore_ForLetterC_ReturnScoreOf3(string value)
    {
      Scrabble newScrabble = new Scrabble(value);
      Assert.True(newScrabble.ScoreChecker() == 3);
    }
  }
}
