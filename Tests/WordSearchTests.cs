using Xunit;
using System;
using System.Collections.Generic;

namespace WordSearch
{
  public class WordSearchTest
  {
//FIND WORD AND MATCH
    [Fact]
    public void Test1_AreWordsIdentical_SearchTrue()
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
    [Fact]
    public void Test2_AreWordsIdentical_SearchFalse()
    {
      //ARRANGE
      string testWord = "hi";
      string matchWord = "hello";
      RepeatSearch newSearch = new RepeatSearch();
      //ACT
      string result = newSearch.Search(testWord);
      //ASSERT
      Assert.Equal(matchWord, result);
    }
    [Fact]
    public void Test3_CountWord_EnterStringCountWords()
    {
      //ARRANGE
      string testSentence = "hello world";
      string matchWord = "hello";
      int counter = 1;
      Counter findWord = new Counter(testSentence, matchWord)
      //ACT
      string result = findWord.CountRepeats();
      //ASSERT
      Assert.Equal(counter, result);
    }
  }
}
