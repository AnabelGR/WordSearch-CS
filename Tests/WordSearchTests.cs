using System;
using System.Collections.Generic;
using Xunit;

namespace WordSearch
{
  public class RepeatSearchTest
  {
    [Fact]
    public void RepeatSearchTest1_Identical_True()
    {
      //ARRANGE
      string testWord = "hi";
      string matchWord = "hi";
      RepeatSearch testRepeatSearch = new RepeatSearch();
      //ACT
      string result =  testRepeatSearch.CountRepeats(testWord);
      //ASSERT
      Assert.Equal(matchWord, result);
    }
  }
}
