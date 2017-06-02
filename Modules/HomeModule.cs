using Nancy;
using System.Collections.Generic;

namespace WordSearch
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/"] = _ => {
        string userSentence = Request.Form["userSentence"];
        string matchWord = Request.Form["matchWord"];
        RepeatCounter newCounter = new RepeatCounter(userSentence, matchWord);
        int result = newCounter.CountRepeats(userSentence, matchWord);
        newCounter.SetWordCount(result);
        return View["result.cshtml", newCounter];
      };
    }
  }
}
