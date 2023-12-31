using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CoffeeAjax
{

    public class CoffeeController: Controller
    {

[HttpGet]
       public JsonResult GetCoffee(){
        var coffeeNames = new string[3]
        {
            "Lattee",
            "Mocha",
            "Coerado"
        };
        return new JsonResult(Ok(coffeeNames));
       }
       [HttpPost]
       public JsonResult PostCoffee(string name)
       {
        return new JsonResult(Ok());
       }
       [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Index Coffee";
            return View();
        }
public string About(){
        return "This is Coffee Project";
    }
    }
    
}