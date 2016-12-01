using Nancy;
using ScrabbleScore.Objects;

namespace ScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/score"] = _ => {
        string input = Request.Form["user-input"];
        Scrabble newScrabble = new Scrabble(input);
        int score = newScrabble.ScoreChecker();
        return View["score.cshtml", score];
      };
    }
  }
}
