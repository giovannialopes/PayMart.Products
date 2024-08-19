using Microsoft.AspNetCore.Mvc;

namespace PayMart.API.Products.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpPost]
    [Route("post")]
    public async Task<IActionResult> Post(
    [FromServices] HttpClient http)
    {

    }
}
