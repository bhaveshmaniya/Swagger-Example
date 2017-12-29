using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class FaqDTO
    {
        public Pagination Pagination { get; set; }
        public IEnumerable<FAQ> Results { get; set; }
    }

    public class FAQ
    {
        public string Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string[] Categories { get; set; }
    }
}