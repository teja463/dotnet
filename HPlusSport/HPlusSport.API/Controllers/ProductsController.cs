using HPlusSport.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Asp.Versioning;

namespace HPlusSport.API.Controllers;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

    private readonly ShopContext shopContext;

    public ProductsController(ShopContext shopContext)
    {
        this.shopContext = shopContext;
        shopContext.Database.EnsureCreated();
    }

    [HttpGet]
    public IEnumerable<Product> GetAllProducts()
    {
        return shopContext.Products.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        Product? product = shopContext.Products.Find(id);
        if(product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpPost]
    public ActionResult<Product> AddProduct(Product product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        shopContext.Products.Add(product);
        shopContext.SaveChanges();

        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateProduct(int id, Product product)
    {
        if ( id != product.Id)
        {
            return BadRequest();
        }
       
        shopContext.Entry(product).State = EntityState.Modified;

        try
        {
            shopContext.SaveChanges();
        }
        catch (DbUpdateConcurrencyException)
        {
            throw;
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(int id)
    {
        Product? product = shopContext.Products.Find(id);
        
        if(product == null)
        {
            return NotFound();
        }

        shopContext.Remove(product);
        shopContext.SaveChanges();
        return Ok(product);
    }

    [HttpGet("Pagination")]
    public ActionResult<Product> ProductsWithPagination([FromQuery] int page, int size)
    {
       return Ok(shopContext.Products.Skip(size * (page -1 )).Take(size).ToList());
    }

    [HttpGet("simple-filter")]
    public List<Product> FilterProducts([FromQuery] ProductQueryParams req)
    {
        return shopContext.Products.Where(p => p.Price >= req.MinPrice && p.Price <= req.MaxPrice).ToList();
    }

    [HttpGet("advanced-filter")]
    public List<Product> AdvancedFilterProducts([FromQuery] ProductQueryParams req)
    {

        IQueryable<Product> products = shopContext.Products;

        if (req.MinPrice != null)
        {
            products = products.Where(p => p.Price >= req.MinPrice);
        }

        if (req.MaxPrice != null)
        {
            products = products.Where(p => p.Price <= req.MaxPrice);
        }

        return products.ToList();
    }

    [HttpGet("available")]
    public List<Product> GetAvailableProducts()
    {
        return shopContext.Products.Where(p => p.IsAvailable).ToList();
    }

    [HttpGet]
    [Route("all2")]
    public ActionResult<IEnumerable<Product>> GetAll2()
    {
        return Ok(shopContext.Products);
    }

    [HttpGet("all-async")]
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await shopContext.Products.ToListAsync();
    }
    
}
