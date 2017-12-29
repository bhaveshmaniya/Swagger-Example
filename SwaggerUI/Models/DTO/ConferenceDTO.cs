using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class ConferenceDTO
    {
        public Pagination Pagination { get; set; }
        public IEnumerable<Conference> Results { get; set; }
    }

    public class Conference
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Details { get; set; }
        public string VenueDetails { get; set; }
        public string TravelDetails { get; set; }
        public string DonationDetails { get; set; }
        public string TicketUrl { get; set; }
        public string Type { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string[] Speackers { get; set; }
        public string RegistrationClosed { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string ExpirationDate { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string BannerUrl { get; set; }
        public string RibbonUrl { get; set; }
    }
}