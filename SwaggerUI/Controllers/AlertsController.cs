using SwaggerUI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerUI.Controllers
{
    [RoutePrefix("api/alerts")]
    public class AlertsController : ApiController
    {
        // Mock Data
        private const string AlertId = "89aeee41-b39f-4fb8-9884-eeedaecaba9d";
        private readonly AlertDTO _alertDTO = new AlertDTO
        {
            Pagination = new Pagination { TotalItems = 1, CurrentPage = 1, PageSize = 10 },
            Results = new List<Alert>
                 {
                     new Alert
                     {
                         Id = AlertId,
                         Html = "HTML",
                         BackgroundColor = "#ff0000",
                         BackgroundImageUrl =  "Background Image Url"
                     }
                 }
        };

        [HttpGet]
        [Route("list")]
        public HttpResponseMessage GetAlerts()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _alertDTO);
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetOfferById(string id)
        {
            HttpResponseMessage response;

            try
            {
                var alert = _alertDTO.Results.FirstOrDefault(x => x.Id == id);

                if (alert == null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound);
                    return response;
                }

                response = Request.CreateResponse(HttpStatusCode.OK, alert);
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
