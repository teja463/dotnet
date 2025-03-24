using CoreWebAppMvc.Data;
using CoreWebAppMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAppMvc.Controllers;


public class ItemsController : Controller
{

    private readonly MyDbContext dbContext;

    public ItemsController(MyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public IActionResult Index()
    {
        var items = dbContext.Items.ToList();
        return View(items);
    }

    public IActionResult Create()
    {
        return View();
    }

    

    
}
