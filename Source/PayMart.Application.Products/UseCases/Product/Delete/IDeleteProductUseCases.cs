﻿using PayMart.Domain.Products.Response.Product;

namespace PayMart.Application.Products.UseCases.Product.Delete;

public interface IDeleteProductUseCases
{    Task<string> Execute(int id); 
}
