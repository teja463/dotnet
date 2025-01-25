using HPlusSport.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSport.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

    private readonly ShopContext _shopContext;

    public ProductsController(ShopContext shopContext)
    {
        _shopContext = shopContext;

        _shopContext.Database.EnsureCreated();
    }

    [HttpGet]
    [Route("all")]
    public IEnumerable<Product> GetAllProducts()
    {

        return _shopContext.Products;
    }

    [HttpGet]
    [Route("all2")]
    public ActionResult<IEnumerable<Product>> GetAll2()
    {
        return Ok(_shopContext.Products);
    }
}
