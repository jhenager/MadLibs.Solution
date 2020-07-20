using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Result(string adj1, string food1, string vegetable1, string food2, string vegetable2, string verb1, string verb2, string vegetable3, string vegetable4, string verb3) 
    {
      MadLibsVariable newMadLibs = new MadLibsVariable(adj1, food1, vegetable1, food2, vegetable2, verb1, verb2, vegetable3, vegetable4, verb3);
      return View(newMadLibs);
    }
  }
}