﻿namespace Shopping.Web.Models.Catalog;

public class ProductModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }
    public List<string> Category { get; set; } = default!;
    public string ImageFile { get; set; } = default!;
}

public record GetProductsResponse(IEnumerable<ProductModel> Products);
public record GetProductByCategoryResponse(IEnumerable<ProductModel> Products);
public record GetProductByIdResponse(ProductModel Product);
