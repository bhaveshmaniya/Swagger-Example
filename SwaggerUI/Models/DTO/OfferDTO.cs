using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class OfferDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string OfferUrl { get; set; }
        public string ImageUrl { get; set; }
        public ProductInfo Product { get; set; }
    }
}