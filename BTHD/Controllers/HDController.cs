using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTHD.Models;


public class HDController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(HDModel model)
    {
        if (ModelState.IsValid)
        {
            model.CalculateTotalAmount();
            ViewBag.Message = "Tổng tiền hóa đơn của bạn là: " + model.Tinhtien.ToString("N0") + " VND";
        }
        else
        {
            ViewBag.Message = "Vui lòng nhập đúng định dạng số lượng và đơn giá!";
        }

        return View(model);
    }
}