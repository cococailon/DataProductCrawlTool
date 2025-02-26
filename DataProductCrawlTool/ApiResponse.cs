using DataProductCrawlTool.Model;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataProductCrawlTool
{
    public class ApiResponse
    {
        public string Status { get; set; }
        public QueryInfo Query { get; set; }
        public List<ProductApi> Data { get; set; }
        public MetaInfo Meta { get; set; }
    }
}