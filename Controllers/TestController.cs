using Microsoft.AspNetCore.Mvc;

namespace cbsStudents.Controllers;

public class TestController : Controller
{
    public ActionResult WannaPlayDad()
    {
        ViewBag.Data = "Hello there";

        return View("WannaPlayDad2");
    }
}