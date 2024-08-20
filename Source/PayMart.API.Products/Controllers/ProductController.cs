using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Products.UseCases.Product;
using PayMart.Domain.Products.Request.Product;

namespace PayMart.API.Products.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpPost]
    [Route("post")]
    public async Task<IActionResult> Post(
    [FromServices] IPostProductUseCases useCases,
    [FromBody] RequestProduct request)
    {
        var response = await useCases.Execute(request);
        return Ok(response);
    }
}
