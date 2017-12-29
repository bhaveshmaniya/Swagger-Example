using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class PrayersRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PrayerRecipient { get; set; }
        public string Category { get; set; }
        public string PrayerText { get; set; }
    }
}