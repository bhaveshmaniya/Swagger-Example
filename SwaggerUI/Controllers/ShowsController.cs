using SwaggerUI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerUI.Controllers
{
    [RoutePrefix("api/shows")]
    public class ShowsController : ApiController
    {
        //Mock Data
        private const string VideoId = "22aeee41-b39f-4fb8-9884-eeedaecaba9d";
        private const string AudioId = "44aeee41-b39f-4fb8-9884-eeedaecaba8d";

        private readonly VideoDTO _videoDTO = new VideoDTO()
        {
            Pagination = new Pagination { TotalItems = 1, CurrentPage = 1, PageSize = 10 },
            Results = new List<Video>
            {
                new Video
                {
                    Id = VideoId,
                    Title ="Why is God Silent?",
                    Categories = new string[] {"Grief","Love" },
                    Summary = "Summary",
                    LiveDate = DateTime.UtcNow.ToString("D"),
                    ExpirationDate = DateTime.UtcNow.AddDays(30).ToString("D"),
                    VideoImageUrl = "Video Image URL",
                    VidoeEmbedcode = "0123456789",
                    VideoSrc = "Video Source",
                    MetaTitle = "Meta Title",
                    MetaDescription = "Meta Description",
                    MetaKeywords = "Meta Keywords",
                    RelatedOffers = new  List<OfferDTO>
                    {
                        new OfferDTO
                        {
                            Id = Guid.NewGuid().ToString(),
                            Title = "Christmas Offer",
                            OfferUrl = "Offer URL",
                            ImageUrl = "Image URL",
                            Product = new ProductInfo
                            {
                                Id = Guid.NewGuid().ToString(),
                                Title = "Never Give Up",
                                Sku = "01234567",
                                Price = 79.99M
                            }
                        }
                    }
                }
            }
        };

        private readonly AudioDTO _audioDTO = new AudioDTO
        {
            Pagination = new Pagination { TotalItems = 1, CurrentPage = 1, PageSize = 10 },
            Results = new List<Audio>
            {
                new Audio {Id= AudioId }
            }
        };

        [HttpGet]
        [Route("videos/list")]
        public HttpResponseMessage GetVideos()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _videoDTO);
        }

        [HttpGet]
        [Route("videos/{id}")]
        public HttpResponseMessage GetVideoById(string id)
        {
            HttpResponseMessage response;

            try
            {
                var video = _videoDTO.Results.FirstOrDefault(x => x.Id == id);

                if (video == null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound);
                    return response;
                }

                response = Request.CreateResponse(HttpStatusCode.OK, video);
                return response;
            }
            catch (Exception ex)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Opps, something went wrong. Please try again!");
                return response;
            }
        }

        [HttpGet]
        [Route("audios/list")]
        public HttpResponseMessage GetAudios()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _audioDTO);
        }

        [HttpGet]
        [Route("audios/{id}")]
        public HttpResponseMessage GetAudioById(string id)
        {
            HttpResponseMessage response;

            try
            {
                var audio = _audioDTO.Results.FirstOrDefault(x => x.Id == id);

                if (audio == null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound);
                    return response;
                }

                response = Request.CreateResponse(HttpStatusCode.OK, audio);
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
