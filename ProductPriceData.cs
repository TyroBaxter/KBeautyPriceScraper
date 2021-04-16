using System;

namespace KBeautyPriceScraper
{
    internal class ProductPriceData
    {
        public decimal ProductPrice { get; set; }
        public int ProductNumber { get; set; }
        public string ProductCode { get; set; }
        public DateTime ViewedDateTime { get; set; }
    }
}