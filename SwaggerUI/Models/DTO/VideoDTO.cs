using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class VideoDTO
    {
        public Pagination Pagination { get; set; }
        public IEnumerable<Video> Results { get; set; }
    }

    public class Video
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public string Summary { get; set; }
        public string LiveDate { get; set; }
        public string ExpirationDate { get; set; }
        public string VideoImageUrl { get; set; }
        public string VidoeEmbedcode { get; set; }
        public string VideoSrc { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public IEnumerable<OfferDTO> RelatedOffers { get; set; }
    }
}