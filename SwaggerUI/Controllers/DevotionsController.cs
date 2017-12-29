using SwaggerUI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerUI.Controllers
{
    [RoutePrefix("api/devotions")]
    public class DevotionsController : ApiController
    {
        // Mock Data
        private const string DevotionId = "33aeee41-b39f-4fb8-9884-eeedaecaba6d";
        private readonly List<DevotionDTO> _devotionDTO = new List<DevotionDTO>
        {
            new DevotionDTO
            {
                        Id = DevotionId,
                        Title = "Title",
                        ArticleText = "Article Text",
                        LiveDate = DateTime.UtcNow.ToString("D"),
                        ExpirationDate = DateTime.UtcNow.AddDays(30).ToString("D"),
                        HeaderTitle = "Header Title",
                        HeaderSubTitle = "Header SubTitle",
                        HeaderImageUrl = "Header Image Url",
                        HeaderTooltip = "Header Tooltip",
                        Summary = "Summary",
                        Author = "Author",
                        BookUrl = "Book Url",
                        PulloutQuote = "Pullout Quote",
                        Categories = new string[] { "Abuse", "Addiction" },
                        MetaTitle = "Meta Title",
                        MetaDescription = "Meta Description",
                        MetaKeywords = "Meta Keywords",
                        HeroImageUrl = "Hero Image Url",
                        VerseQuote = "Verse Quote",
                        QuoteScripture = "Quote Scripture",
                        ImageUrl = "Image Url",
                        SocialImageUrl = "Social Image Url"
            }
        };

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetDevotionById(string id)
        {
            HttpResponseMessage response;

            try
            {
                var devotion = _devotionDTO.FirstOrDefault(x => x.Id == id);

                if (devotion == null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound);
                    return response;
                }

                response = Request.CreateResponse(HttpStatusCode.OK, devotion);
                return response;
            }
            catch (Exception ex)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Opps, something went wrong. Please try again!");
                return response;
            }
        }
    }
}
