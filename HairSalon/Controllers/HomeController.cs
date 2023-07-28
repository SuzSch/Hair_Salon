using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Solutions.Models;

namespace HairSalon.Solutions.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }

    


