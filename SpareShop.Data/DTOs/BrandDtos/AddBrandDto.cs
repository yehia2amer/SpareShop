﻿namespace SpareShop.Data.DTOs.BrandDtos;

    public class AddBrandDto : IDtos
{
    public string Name { get; set; } = string.Empty;
    public string ImgPath { get; set; } = string.Empty;
}
