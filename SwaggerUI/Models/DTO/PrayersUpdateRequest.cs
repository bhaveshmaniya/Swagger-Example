using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class PrayersUpdateRequest
    {
        public string Id { get; set; }
        public bool IsAnswered { get; set; }
    }
}