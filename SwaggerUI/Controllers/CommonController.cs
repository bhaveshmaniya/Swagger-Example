using SwaggerUI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerUI.Controllers
{
    [RoutePrefix("api/common/dictionaries")]
    public class CommonController : ApiController
    {
        // Mock Data
        private readonly List<DictionaryDTO> _dictionaries = new List<DictionaryDTO>()
        {
            new DictionaryDTO { Key="Key1", Value="Value1"},
            new DictionaryDTO { Key="Key2", Value="Value2"},
            new DictionaryDTO { Key="Key3", Value="Value3"},
            new DictionaryDTO { Key="Key4", Value="Value4"}
        };

        /// <summary>
        /// The language version to pull from the Sitecore Dictionaries. By default if no value is specified en will be used.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _dictionaries);
        }

        /// <summary>
        /// The language version to pull from the Sitecore Dictionaries. By default if no value is specified en will be used.
        /// </summary>
        /// <param name="key">Dictionary Key</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{key}")]
        public HttpResponseMessage GetByKey(string key)
        {
            HttpResponseMessage response;

            try
            {
                var dictionaryDTO = _dictionaries.FirstOrDefault(x => x.Key == key);

                if (dictionaryDTO == null)
                {
                    response = Request.CreateResponse(HttpStatusCode.NotFound);
                    return response;
                }

                response = Request.CreateResponse(HttpStatusCode.OK, dictionaryDTO);
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
