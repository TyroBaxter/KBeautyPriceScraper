using System;

namespace KBeautyPriceScraper
{
    public class ProductPriceData
    {
        public decimal ProductPrice { get; set; }
        public int ProductNumber { get; set; }
        public string ProductCode { get; set; }
        public DateTime ViewedDateTime { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(ProductPrice)}: {ProductPrice}, " +
                $"{nameof(ProductNumber)}: {ProductNumber}, " +
                $"{nameof(ProductCode)}: {ProductCode}, " +
                $"{nameof(ViewedDateTime)}: {ViewedDateTime}";
        }

        
    }
}