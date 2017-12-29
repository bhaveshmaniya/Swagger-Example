using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class PrayerDTO
    {
        public Pagination Pagination { get; set; }
        public IEnumerable<Prayer> Results { get; set; }
    }

    public class Prayer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsAnswered { get; set; }
        public string PrayerRecipient { get; set; }
        public string Category { get; set; }
        public string PrayerText { get; set; }
    }
}