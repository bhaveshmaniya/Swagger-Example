using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerUI.Models.DTO
{
    public class AudioDTO
    {
        public Pagination Pagination { get; set; }
        public IEnumerable<Audio> Results { get; set; }
    }

    public class Audio
    {
        public string Id { get; set; }
    }
}