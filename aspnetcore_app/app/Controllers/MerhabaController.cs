using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app.Models;

namespace app.Controllers;

public class MerhabaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
