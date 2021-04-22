using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using System.Configuration;
using System.Collections.Specialized;

namespace KBeautyPriceScraper
{
    public interface IWriteData
    {
        public void WriteData(ProductPriceData productPriceData);
    }
    public class WriteDataCsv : IWriteData
    {
        private readonly string _csvLocation;
        public WriteDataCsv()
        {
            var csvLocation = ConfigurationManager.AppSettings.Get("Key0");
            _csvLocation = csvLocation;
        }
        public void WriteData(ProductPriceData productPriceData)
        {
            using var writer = new StreamWriter(_csvLocation);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecord(productPriceData);
        }
    }
}
