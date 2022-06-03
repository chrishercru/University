using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace University.DTOs
{
    public class CourseDTO
    {

        [JsonProperty("Course")]
        public int CourseID { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Credits")]
        public string Credits { get; set; }


    }
}
