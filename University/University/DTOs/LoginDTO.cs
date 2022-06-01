using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace University.DTOs
{
    public class LoginReqDTO
    {
        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("password")]
        public string password { get; set; }

    }

    public class LoginResDTO
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class LoginResFailDTO
    {
         [JsonProperty("error")]
        public string Error { get; set; 

    }
}
