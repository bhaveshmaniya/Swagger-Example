using SwaggerUI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerUI.Controllers
{
    [RoutePrefix("api/conferences")]
    public class ConferencesController : ApiController
    {
        //Mock Data
        private const string ConferenceId = "22aeee41-b39f-4fb8-9884-eeedaecaba9d";
        private readonly ConferenceDTO _conferenceDTO = new ConferenceDTO()
        {
            Pagination = new Pagination { TotalItems = 1, CurrentPage = 1, PageSize = 10 },
            Results = new List<Conference>
            {
                new Conference
                {
                    Id = ConferenceId,
                    Title = "Title",
                    SubTitle = "Sub Title",
                    Details = "Details",
                    VenueDetails = "Venue Details",
                    TravelDetails = "Travel Details",
                    DonationDetails = "Donation Details",
                    TicketUrl = "Ticket Url",
                    Type = "Conference Tour",
                    StartDate = DateTime.UtcNow.AddDays(7).ToString("D"),
                    EndDate = DateTime.UtcNow.AddDays(15).ToString("D"),
                    Address = "3001 Civic Center Cir NE, Rio Rancho, NM 87144",
                    Location = "Santa Ana Star Center",
                    Speackers = new string[] { "ABC", "XYZ"},
                    RegistrationClosed = DateTime.UtcNow.AddDays(4).ToString("D"),
                    MetaTitle = "Meta Title",
                    MetaDescription = "Meta Description",
                    MetaKeywords = "Meta Keywords",
                    ExpirationDate = DateTime.UtcNow.AddDays(30).ToString("D"),
                    ImageUrl = "Image Url",
                    ThumbnailUrl = "Thumbnail Url",
                    BannerUrl = "Banner Url",
                    RibbonUrl = "Ribbon Url"
                }
            }
        };

        [HttpGet]
        [Route("list")]
        public HttpResponseMessage GetConferences()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _conferenceDTO);
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetConferenceById(string id)
        {
            HttpResponseMessage response;

            try
            {
                var conference = _conferenceDTO.Results.FirstOrDefault(x => x.Id == id);

                if (conference == null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound);
                    return response;
                }

                response = Request.CreateResponse(HttpStatusCode.OK, conference);
                return response;
            }
            catch (Exception ex)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Opps, something went wrong. Please try again!");
                return response;
            }
        }

        [HttpPost]
        [Route("checkin/{id}")]
        public HttpResponseMessage ConferenceCheckIn(ConferenceCheckInRequest conferenceCheckInRequest)
        {
            HttpResponseMessage response;

            try
            {
                var baseResponse = new BaseResponse
                {
                    Success = true,
                    Message = "Conference check-in successfully."
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

        [HttpPost]
        [Route("checkin/volunteer")]
        public HttpResponseMessage AddConferenceVolunteer(ConferenceVolunteerRequest conferenceVolunteerRequest)
        {
            HttpResponseMessage response;

            try
            {
                var baseResponse = new BaseResponse
                {
                    Success = true,
                    Message = "Conference volunteer added successfully."
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
