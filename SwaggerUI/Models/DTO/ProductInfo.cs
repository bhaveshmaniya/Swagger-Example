using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class ProductInfo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }
    }
}