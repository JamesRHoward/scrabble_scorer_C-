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
    [Fact]
    public void ScrabbleScore_ReturnsFiveForWordCat_True()
    {
      string input = "cat";
      Scrabble testScrabble = new Scrabble(input);
      int result = testScrabble.ScoreChecker();
      Assert.Equal(5, result);
    }
    [Fact]
    public void ScrabbleScore_ReturnsFiveForWordcAt_True()
    {
      string input = "cAt";
      Scrabble testScrabble = new Scrabble(input);
      int result = testScrabble.ScoreChecker();
      Assert.Equal(5, result);
    }
    [Fact]
    public void ScrabbleScore_ReturnsFiveForWordQuiz_True()
    {
      string input = "quiz";
      Scrabble testScrabble = new Scrabble(input);
      int result = testScrabble.ScoreChecker();
      Assert.Equal(22, result);
    }
  }
}
