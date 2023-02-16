using Bakery.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Api.Controllers;

[ApiController]
//[Route("Products")]
public class ProductController : ControllerBase
{


    [HttpGet]
    [Route("/GetProduct")]
    public IActionResult Get()
    {
        var product = new Product(1, "Salgadinho");
        return Ok(product);

    }

    [HttpGet]
    [Route("/GetProducts")]
    public IActionResult GetAll(){
        var products = new List<Product>();
        var product = new Product(1, "chocolate");
        products.Add(product); 
        var productteste = new Product(2, "Nuggets");
        products.Add(productteste);
        return Ok(products);
        
    }

}
