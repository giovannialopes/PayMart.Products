using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Products.UseCases.Product.GetAll;
using PayMart.Application.Products.UseCases.Product.Post;
using PayMart.Domain.Products.Request.Product;

namespace PayMart.API.Products.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet]
    [Route("getAll")]
    public async Task<IActionResult> GetAll(
    [FromServices] IGetAllProductUseCases useCases)
    {
        var response = await useCases.Execute();
        return Ok(response);
    }

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
