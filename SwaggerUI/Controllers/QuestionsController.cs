using SwaggerUI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerUI.Controllers
{
    [RoutePrefix("api/questions")]
    public class QuestionsController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage AskQuestion(QuestionRequest questionRequest)
        {
            HttpResponseMessage response;

            try
            {
                var baseResponse = new BaseResponse
                {
                    Success = true,
                    Message = "Question added successfully."
                };

                response = Request.CreateResponse(HttpStatusCode.OK, baseResponse);
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
