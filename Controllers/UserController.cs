using Microsoft.AspNetCore.Mvc;
using Project_management.Data;

namespace Project_management.Controllers;

public class UserController : Controller
{
    private ApplicationDbContext context;


    public UserController(ApplicationDbContext ctx)
    {
        context = ctx;
    }

    public IActionResult Index()
    {
        ViewBag.Users = context.Users.ToList();
        return View("Index", context.Users.ToList());
    }

    public IActionResult Create()
    {
        return View();
    }

}