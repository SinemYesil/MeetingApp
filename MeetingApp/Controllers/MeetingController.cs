﻿using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class MeetingController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Apply()
    {
        return View();
    }
    public IActionResult List()
    {
        return View();
    }
}