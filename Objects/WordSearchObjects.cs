using System;
using System.Collections.Generic;

namespace WordSearch
{
  public class RepeatCounter
  {
    private string _userSentence;
    private string _matchWord;
    private int _wordCount;

    public RepeatCounter(string userSentence, string matchWord)
    {
      _userSentence = userSentence;
      _matchWord = matchWord;
      _wordCount = 0;
    }

    public string GetUserSentence()
    {
      return _userSentence;
    }

    public string GetMatchrWord()
    {
      return _matchWord;
    }
    public int GetWordCount()
    {
      return _wordCount;
    }
    public void SetWordCount(int wordCount)
    {
      _wordCount = wordCount;
    }

    public int CountRepeats(string userSentence, string matchWord)
    {
      userSentence = userSentence.ToLower();
      matchWord = matchWord.ToLower();
      string[] userSentenceArray = userSentence.Split(' ');
      int _wordCount = 0;
      for (int i = 0; i < userSentenceArray.Length; i++)
      {
        if (userSentenceArray[i] == matchWord)
        {
          _wordCount += 1;
        }
        else 
        {
          _wordCount += 0;
        }
      }
      return _wordCount;
      }
    }
  }
