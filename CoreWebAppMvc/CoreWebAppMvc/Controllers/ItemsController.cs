using CoreWebAppMvc.Data;
using CoreWebAppMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        var items = dbContext.Items.Include(i => i.SerialNumber).ToList();
        return View(items);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create([Bind("Id, Name, Price")] Item item)
    {
        if (ModelState.IsValid)
        {
            dbContext.Items.Add(item);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }


    public IActionResult Edit(int id)
    {
        Item? dbItem = dbContext.Items.Find(id);
        return View(dbItem);
    }

    [HttpPost]
    public IActionResult Edit(int id, [Bind("Id, Name, Price")] Item item)
    {

        if (ModelState.IsValid)
        {
            dbContext.Update(item);
            dbContext.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Item? item = dbContext.Items.Find(id);
        if (item != null)
        {
            dbContext.Items.Remove(item);
            dbContext.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}
