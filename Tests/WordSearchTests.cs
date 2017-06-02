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
      RepeatCounter newCounter = new RepeatCounter();
      //ACT
      string result =  newCounter.Search(testWord);
      //ASSERT
      Assert.Equal(matchWord, result);
    }
    [Fact]
    public void Test2_AreWordsIdentical_SearchFalse()
    {
      //ARRANGE
      string testWord = "hi";
      string matchWord = "hello";
      RepeatCounter newCounter = new RepeatCounter();
      //ACT
      string result = newCounter.Search(testWord);
      //ASSERT
      Assert.Equal(matchWord, result);
    }
    [Fact]
    public void Test3_CountOneWord_EnterStringCountWord()
    {
      //ARRANGE
      string testSentence = "hello world";
      string matchWord = "hello";
      int wordCount = 1;
      RepeatCounter newCounter = new RepeatCounter();
      //ACT
      int result = newCounter.CountRepeats(testSentence, matchWord);
      //ASSERT
      Assert.Equal(wordCount, result);
    }
    [Fact]
    public void Test4_CountAllInstancesOfWord_EnterStringCountWords()
    {
      //ARRANGE
      string testSentence = "hello world, hello universe";
      string matchWord = "hello";
      int wordCount = 2;
      RepeatCounter newCounter = new RepeatCounter();
      //ACT
      int result = newCounter.CountRepeats(testSentence, matchWord);
      //ASSERT
      Assert.Equal(wordCount, result);
    }
    [Fact]
    public void Test5_SentenceIgnoreCase_IgnoreCase()
    {
      //ARRANGE
      string testSentence = "Hello world, hEllo universe";
      string matchWord = "hello";
      int wordCount = 2;
      RepeatCounter newCounter = new RepeatCounter();
      //ACT
      int result = newCounter.CountRepeats(testSentence, matchWord);
      //ASSERT
      Assert.Equal(wordCount, result);
    }
  }
}
