using System;
using RockPaperScissors.Objects;
using Nancy;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        string result = "";
        return View["index.cshtml", result];
      };

      Post["/"] = _ => {
        Game newGame = new Game(Request.Form["input1"], Request.Form["input2"]);
        string result = newGame.GetResults();
        return View["index.cshtml", result];
      };
    }
  }
}
