using DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class HomeController : Controller
{
    private AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.SlideItems);
        #region ViewBag,Tempdata,Redirect
        //ViewBag.Name = "Metin";
        //ViewData["Surname"] = "Iskenderov";
        //TempData["Age"] = 5;
        //return RedirectToAction(nameof(Test));
        //return RedirectToAction("Test");
        //return Test();
        //return View(nameof(Test));
        #endregion
    }
}
