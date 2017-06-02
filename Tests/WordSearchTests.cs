using Xunit;
using System;
using System.Collections.Generic;

namespace WordSearch
{
  public class WordSearchTest
  {
//FIND WORD AND MATCH
    [Fact]
    public void Test1_AreWordsIdentical_Search()
    {
      //ARRANGE
      string testWord = "hi";
      string matchWord = "hi";
      RepeatSearch newSearch = new RepeatSearch();
      //ACT
      string result =  newSearch.Search(testWord);
      //ASSERT
      Assert.Equal(matchWord, result);
    }
  }
}
