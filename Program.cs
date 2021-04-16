using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KBeautyPriceScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var kBeautyUri = new Uri("https://jolse.com/exec/front/shop/CalculatorProduct?product_no=3365&product%5BP0000EZK000A%5D=2");
            var data = GetDataFromUri(kBeautyUri);
            Console.WriteLine(data);
        }

        static ProductPriceData GetDataFromUri(Uri uri)
        {
            var wc = new WebClient();
            var downloadedData = wc.DownloadString(uri);

            //var parsedData = JsonConvert.DeserializeObject<Rootobject>(downloadedData);
            var parsedData = JObject.Parse(downloadedData);
            var priceData = parsedData.Children()
                                      .First()
                                      .ToObject<ItemDetails>();
            return new ProductPriceData();
        }
    }
}
