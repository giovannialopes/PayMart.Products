using Microsoft.AspNetCore.Mvc;
using PayMart.Domain.Products.Model;
using PayMart.Domain.Products.Services;

namespace PayMart.API.Products.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet]
    [Route("getAll")]
    public async Task<IActionResult> GetAllProduct(
        [FromServices] IProductServices services)
    {
        var response = await services.GetProducts();
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpGet]
    [Route("getID/{id}")]
    public async Task<IActionResult> GetProductByID(
        [FromServices] IProductServices services,
        [FromRoute] int id)
    {
        var response = await services.GetProductById(id);
        if (response == null)
            return Ok("");

        return Ok(response);
    }


    [HttpPost]
    [Route("post/{userID}")]
    public async Task<IActionResult> RegisterProduct(
        [FromServices] IProductServices services,
        [FromBody] ModelProduct.CreateProductRequest request,
        [FromRoute] int userID)
    {
        request.UserId = userID;

        var response = await services.CreateProduct(request);
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpPut]
    [Route("update/{id}/{userID}")]
    public async Task<IActionResult> UpdateProduct(
        [FromServices] IProductServices services,
        [FromRoute] int id,
        [FromRoute] int userID,
        [FromBody] ModelProduct.UpdateProductRequest request)
    {
        request.UserId = userID;
        var response = await services.UpdateProduct(request, id);
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> DeleteProduct(
        [FromServices] IProductServices services,
        [FromRoute] int id)
    {
        var response = await services.DeleteProduct(id);
        if (response == null)
            return Ok("");

        return Ok(response);
    }
}
