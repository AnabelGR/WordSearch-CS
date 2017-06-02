using System;
using System.Collections.Generic;

namespace WordSearch
{
  public class RepeatCounter
  {
    private string _userSentence;
    private string _userWord;
    private int _wordCount;

    public RepeatCounter(string userSentence, string userWord, int wordCount)
    {
      _userSentence = userSentence;
      _userWord = userWord;
      _wordCount = 0;
    }

    public int CountRepeats()
    {
      string[] userSentenceSplit = _userSentence.ToLower()Split.(' ');
      for (int i = 0; i < userSentenceSplit.Length; i++)
      {
        if (userSentenceSplit[i] == _userWord.ToLower())
        {
          _wordCount += 1;
        }
      }
      return _wordCount;
    }
  }
}
