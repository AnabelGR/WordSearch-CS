using Xunit;
using System;
using System.Collections.Generic;

namespace WordSearch
{
  public class WordSearchTest
  {
//FIND WORD AND MATCH
    [Fact]
    public void Test1_AreWordsIdentical_Count()
    {
      //ARRANGE
      string testWord = "hi";
      string matchWord = "hi";
      int wordCount = 0;
      RepeatCounter newCounter = new RepeatCounter();
      //ACT
      int result =  newCounter.CheckRepeatCounter(testWord, matchWord);
      //ASSERT
      Assert.Equal(wordCount, result);
    }
//FIND WORD AND NOT MATCH
    [Fact]
    public void Test2_AreWordsNotIdentical_Count()
    {
      //ARRANGE
      string testWord = "hi";
      string matchWord = "no";
      int wordCount = 0;
      RepeatCounter newCounter = new RepeatCounter();
      //ACT
      int result =  newCounter.CheckRepeatCounter(testWord, matchWord);
      //ASSERT
      Assert.Equal(wordCount, result);
    }
    //FIND WORD IN A SENTENCE
        [Fact]
        public void Test3_CountOneInASentence_Count()
        {
          //ARRANGE
          string testWord = "hi world";
          string matchWord = "hi";
          int wordCount = 1;
          RepeatCounter newCounter = new RepeatCounter();
          //ACT
          int result =  newCounter.CheckRepeatCounter(testWord, matchWord);
          //ASSERT
          Assert.Equal(wordCount, result);
        }
  }
}
