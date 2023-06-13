﻿using System.Text.Json;
using SpareShop.Domain.Entities;

namespace SpareShop.Data.SeedData
{
    public static class SeedData
    {
        public static void Seed()
        {
            using ApplicationDbContext context = new();
            context.Database.EnsureCreated();

            // const string fileNameBrands = @"../SpareShop.Data/SeedData/Brands.json";
            // string jsonStringBrands = File.ReadAllText(fileNameBrands);
            // var brands = JsonSerializer.Deserialize<List<Brand>>(jsonStringBrands);
            //
            // const string fileNameCategories = @"../SpareShop.Data/SeedData/Categories.json";
            // string jsonStringCategories = File.ReadAllText(fileNameCategories);
            // var categories = JsonSerializer.Deserialize<List<Category>>(jsonStringCategories);
            //
            // const string fileNameProducts = @"../SpareShop.Data/SeedData/Products.json";
            // string jsonStringProducts = File.ReadAllText(fileNameProducts);
            // var products = JsonSerializer.Deserialize<List<ProductDemo>>(jsonStringProducts);
            //
            //
            // const string fileName2 = @"../SpareShop.Data/SeedData/Products2.json";
            // using FileStream createStream2 = File.Create(fileName2);
            // JsonSerializer.Serialize(createStream2, products);
            // createStream2.Dispose();
            //
            // context.Brands.AddRange(brands!);
            // context.Categories.AddRange(categories!);
            // context.SaveChanges();
            //
            // foreach (ProductDemo product in products!)
            // {
            //     product.UserId = Guid.Parse("A4C17BC3-CFB3-4896-BF74-BC24593A84D1");
            // }
            // context.Products.AddRange(products);
            // context.SaveChanges();
        }
    }
}
