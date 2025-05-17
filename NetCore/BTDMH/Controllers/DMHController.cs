using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTDMH.Models;

public class DMHController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(DMHModel model)
    {
        if (ModelState.IsValid)
        {
            model.CalculateFinalScore();
            ViewBag.Message = "Điểm tổng kết của bạn là: " + model.FinalScore;
        }
        else
        {
            ViewBag.Message = "Vui lòng nhập đúng định dạng điểm!";
        }

        return View(model);
    }
}