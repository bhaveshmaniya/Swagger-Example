using SwaggerUI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerUI.Controllers
{
    [RoutePrefix("api/offers")]
    public class OffersController : ApiController
    {
        // Mock Data
        private const string OfferId = "22aeee41-b39f-4fb8-9884-eeedaecaba9d";
        private readonly List<OfferDTO> _offers = new List<OfferDTO>
        {
         new OfferDTO{
             Id = OfferId,
             Title = "Christmas Offer",
             OfferUrl = "Offer URL",
             ImageUrl = "Image URL",
             Product = new ProductInfo
             {
                Id =Guid.NewGuid().ToString(),
                Title = "Never Give Up",
                Sku = "01234567",
                Price = 79.99M
             }
         }
        };

        [HttpGet]
        [Route("list")]
        public HttpResponseMessage GetOffers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _offers);
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetOfferById(string id)
        {
            HttpResponseMessage response;

            try
            {
                var offer = _offers.FirstOrDefault(x => x.Id == id);

                if (offer == null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound);
                    return response;
                }

                response = Request.CreateResponse(HttpStatusCode.OK, offer);
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
