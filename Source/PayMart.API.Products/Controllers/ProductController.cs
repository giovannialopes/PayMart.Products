using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Products.UseCases.Product.Delete;
using PayMart.Application.Products.UseCases.Product.GetAll;
using PayMart.Application.Products.UseCases.Product.GetID;
using PayMart.Application.Products.UseCases.Product.GetSum;
using PayMart.Application.Products.UseCases.Product.Post;
using PayMart.Application.Products.UseCases.Product.Update;
using PayMart.Application.Products.Utilities;
using PayMart.Domain.Products.Request.Product;
using PayMart.Infrastructure.Products.Migrations;

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

    [HttpGet]
    [Route("restartProduct")]
    public IActionResult RestartProduct()
    {
        SaveProductID.SaveProductId(0);

        return Ok();
    }

    [HttpGet]
    [Route("getSumProducts/{productID}")]
    public async Task<IActionResult> GetSumProducts(
    [FromRoute] int productID,
    [FromServices] IGetSumProductUseCases useCases)
    {
        var response = await useCases.Execute(productID);
        return Ok(response);
    }

    [HttpPost]
    [Route("post/{userID}")]
    public async Task<IActionResult> Post(
        [FromServices] IPostProductUseCases useCases,
        [FromBody] RequestProduct request,
        [FromRoute] int userID)
    {

        var productId = SaveProductID.GetProductId();

        if (productId == 0)
        {
            productId = NumberGenerator.Generate();
            SaveProductID.SaveProductId(productId);
        }

        request.UserID = userID;
        request.ProductID = productId;
        var response = await useCases.Execute(request);
        return Ok(response);
    }

    [HttpPut]
    [Route("update/{id}/{userID}")]
    public async Task<IActionResult> Update(
        [FromRoute] int id, int userID,
        [FromServices] IUpdateProductUseCases useCases,
        [FromBody] RequestProduct request)
    {
        request.UserID = userID;
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
