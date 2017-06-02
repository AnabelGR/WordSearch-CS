using Xunit;
using System;
using System.Collections.Generic;

namespace WordSearch
{
  public class WordSearchTest
  {
//FIND WORD AND MATCH
    [Fact]
    public void Test1_AreWordsIdentical_CountRepeats()
    {
      //ARRANGE
      string userSentence = "hi";
      string matchWord = "hi";
      RepeatCounter newCounter = new RepeatCounter(userSentence, matchWord);
      //ACT
      int result = newCounter.CountRepeats(userSentence, matchWord);
      //ASSERT
      Assert.Equal(1, result);
    }
//FIND WORD AND NOT MATCH
    [Fact]
    public void Test2_AreWordsNotIdentical_CountRepeats()
    {
      //ARRANGE
      string userSentence = "hi";
      string matchWord = "no";
      RepeatCounter newCounter = new RepeatCounter(userSentence, matchWord);
      //ACT
      int result =  newCounter.CountRepeats(userSentence, matchWord);
      //ASSERT
      Assert.Equal(0, result);
    }
//FIND WORD IN A SENTENCE
    [Fact]
    public void Test3_CountOneInASentence_CountRepeats()
    {
      //ARRANGE
      string userSentence = "hi world";
      string matchWord = "hi";
      RepeatCounter newCounter = new RepeatCounter(userSentence, matchWord);
      //ACT
      int result =  newCounter.CountRepeats(userSentence, matchWord);
      //ASSERT
      Assert.Equal(1, result);
    }
  }
}
