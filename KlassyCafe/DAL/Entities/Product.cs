﻿namespace KlassyCafe.DAL.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
        public bool IsFeature { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
