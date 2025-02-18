using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.Message = "This is the Employee Index page.";
        return View();
    }

    public ActionResult Details()
    {
        ViewBag.Message = "This is the Employee Details page.";
        return View();
    }
}
