using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Products.UseCases.Product.Delete;
using PayMart.Application.Products.UseCases.Product.GetAll;
using PayMart.Application.Products.UseCases.Product.GetID;
using PayMart.Application.Products.UseCases.Product.Post;
using PayMart.Application.Products.UseCases.Product.Update;
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

    [HttpGet]
    [Route("getID/{id}")]
    public async Task<IActionResult> GetID(
        [FromRoute] int id,
        [FromServices] IGetIDProductUseCases useCases)
    {
        var response = await useCases.Execute(id);
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

    [HttpPut]
    [Route("update/{id}")]
    public async Task<IActionResult> Update(
        [FromRoute] int id,
        [FromServices] IUpdateProductUseCases useCases,
        [FromBody] RequestProduct request)
    {
        var response = await useCases.Execute(request, id);
        return Ok(response);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> Delete(
    [FromRoute] int id,
    [FromServices] IDeleteProductUseCases useCases)
    {
        await useCases.Execute(id);
        return Ok();
    }
}
