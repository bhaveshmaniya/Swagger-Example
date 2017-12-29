using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class AlertDTO
    {
        public Pagination Pagination { get; set; }
        public IEnumerable<Alert> Results { get; set; }
    }

    public class Alert
    {
        public string Id { get; set; }
        public string Html { get; set; }
        public string BackgroundColor { get; set; }
        public string BackgroundImageUrl { get; set; }
    }
}