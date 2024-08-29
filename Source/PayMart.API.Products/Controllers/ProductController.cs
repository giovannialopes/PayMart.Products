using Microsoft.AspNetCore.Mvc;
using PayMart.Domain.Products.Services.Product.Delete;
using PayMart.Domain.Products.Services.Product.GetAll;
using PayMart.Domain.Products.Services.Product.GetID;
using PayMart.Domain.Products.Services.Product.GetSum;
using PayMart.Domain.Products.Services.Product.Post;
using PayMart.Domain.Products.Services.Product.Update;
using PayMart.Domain.Products.Utilities;
using PayMart.Domain.Products.Model;

namespace PayMart.API.Products.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet]
    [Route("getAll")]
    public async Task<IActionResult> GetAllProduct(
        [FromServices] IGetAllProduct services)
    {
        var response = await services.Execute();
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpGet]
    [Route("getID/{id}")]
    public async Task<IActionResult> GetProductByID(
        [FromRoute] int id,
        [FromServices] IGetProductByID services)
    {
        var response = await services.Execute(id);
        if (response == null)
            return Ok("");

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
    [FromServices] IGetSumProduct services)
    {
        var response = await services.Execute(productID);
        if (response == 0)
            return Ok("");

        return Ok(response);
    }

    [HttpPost]
    [Route("post/{userID}")]
    public async Task<IActionResult> RegisterProduct(
        [FromServices] IRegisterProduct services,
        [FromBody] ModelProduct.CreateProductRequest request,
        [FromRoute] int userID)
    {
        request.UserId = userID;
        request.ProductId = ProductIdGenerator.ReturnID();
        var response = await services.Execute(request);
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpPut]
    [Route("update/{id}/{userID}")]
    public async Task<IActionResult> UpdateProduct(
        [FromRoute] int id, int userID,
        [FromServices] IUpdateProduct services,
        [FromBody] ModelProduct.UpdateProductRequest request)
    {
        request.UserId = userID;
        var response = await services.Execute(request, id);
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> DeleteProduct(
    [FromRoute] int id,
    [FromServices] IDeleteProduct services)
    {
        var response = await services.Execute(id);
        if (response == null)
            return Ok("");

        return Ok(response);
    }
}
