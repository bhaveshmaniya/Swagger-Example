using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class DevotionDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ArticleText { get; set; }
        public string LiveDate { get; set; }
        public string ExpirationDate { get; set; }
        public string HeaderTitle { get; set; }
        public string HeaderSubTitle { get; set; }
        public string HeaderImageUrl { get; set; }
        public string HeaderTooltip { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public string BookUrl { get; set; }
        public string PulloutQuote { get; set; }
        public string[] Categories { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string HeroImageUrl { get; set; }
        public string VerseQuote { get; set; }
        public string QuoteScripture { get; set; }
        public string ImageUrl { get; set; }
        public string SocialImageUrl { get; set; }
    }
}