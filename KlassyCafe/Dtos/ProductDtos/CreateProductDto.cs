﻿namespace KlassyCafe.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
        public bool IsFeature { get; set; }
        public int CategoryId { get; set; }
    }
}
