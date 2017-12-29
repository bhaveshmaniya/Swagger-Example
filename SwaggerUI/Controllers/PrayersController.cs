using SwaggerUI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerUI.Controllers
{
    [RoutePrefix("api/prayers")]
    public class PrayersController : ApiController
    {
        // Mock Data
        private const string PrayerId = "22aeee41-b39f-4fb8-9884-eeedaecaba9d";
        private readonly PrayerDTO _prayerDTO = new PrayerDTO
        {
            Pagination = new Pagination { TotalItems = 1, CurrentPage = 1, PageSize = 10 },
            Results = new List<Prayer>
                 {
                     new Prayer
                     {
                         Id = PrayerId,
                         FirstName = "First Name",
                         LastName = "Last Name",
                         Email = "email@email.com",
                         IsAnswered = false,
                         PrayerRecipient = "Prayer Recipient",
                         Category = "Grief",
                         PrayerText = "PrayerT ext"
                     }
                 }
        };

        /// <summary>
        /// This is used to post a new Prayer Request.
        /// </summary>
        /// <param name="prayersRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("request")]
        public HttpResponseMessage AddPrayer(PrayersRequest prayersRequest)
        {
            HttpResponseMessage response;

            try
            {
                var baseResponse = new BaseResponse
                {
                    Success = true,
                    Message = "Prayer added successfully."
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

        /// <summary>
        /// Used to update an existing prayer request. You are required to pass a prayer request id and then you would post additional information.
        /// </summary>
        /// <param name="prayersRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("request/{id}")]
        public HttpResponseMessage UpdatePrayer(PrayersUpdateRequest prayersUpdateRequest)
        {
            HttpResponseMessage response;

            try
            {
                var baseResponse = new BaseResponse
                {
                    Success = true,
                    Message = "Prayer updated successfully."
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

        [HttpGet]
        [Route("list/{userId}")]
        public HttpResponseMessage GetPrayersByUserId(string userId)
        {
            //TODO: Filter Prayers based on userId
            return Request.CreateResponse(HttpStatusCode.OK, _prayerDTO);
        }
    }
}
