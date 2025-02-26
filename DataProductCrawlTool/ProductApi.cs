using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProductCrawlTool
{
    public class ProductApi
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? SKU { get; set; }
        public DateTime? Updated_At { get; set; }
        public DateTime? Created_At { get; set; }
        public string? Link { get; set; }
        public decimal? Min_Price { get; set; }
        public decimal? Avg_Price { get; set; }
        public decimal? Max_Price { get; set; }
    }
}
