using CoreWebAppMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAppMvc.Controllers;

[Route("Custom")]
public class CustomController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

/*
 * pass name in query param like ?name=test
 * total url will be /teja/plaincontent/44?name=test
 */
    [Route("plaincontent/{id?}")]
    public IActionResult Content(int id, string name)
    {
        return Content("Plain Content" + id + name);
    }

    [Route("razorsyntax")]
    public IActionResult RazorSyntax()
    {
        return View("myview");
    }

    [Route("overview")]
    public IActionResult Overview()
    {
        Item item = new Item() { Id = 10, Name = "Teja" };
        return View(item);
    }
}