using SwaggerUI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerUI.Controllers
{
    [RoutePrefix("api/faqs")]
    public class FAQsController : ApiController
    {
        // Mock Data
        private const string FAQId = "89aeee41-b39f-4fb8-9884-eeedaecaba9d";
        private readonly FaqDTO _faqDTO = new FaqDTO
        {
            Pagination = new Pagination { TotalItems = 1, CurrentPage = 1, PageSize = 10 },
            Results = new List<FAQ>
                 {
                     new FAQ
                     {
                         Id = FAQId,
                         Question = "What's the meaning of life?",
                         Answer = "It's awesome",
                         Categories = new string[] {"Love", "Grief" }
                     }
                 }
        };

        [HttpGet]
        [Route("list")]
        public HttpResponseMessage GetFAQs()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _faqDTO);
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetFAQById(string id)
        {
            HttpResponseMessage response;

            try
            {
                var faq = _faqDTO.Results.FirstOrDefault(x => x.Id == id);

                if (faq == null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound);
                    return response;
                }

                response = Request.CreateResponse(HttpStatusCode.OK, faq);
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
