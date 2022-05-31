using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace University.ViewModels.Forms
{
    public class LoginViewModel
    {
        private string _email;
        private string _password;

        async void Login()

        {
            var data = new { email = _email, password = _password };
            var json = JsonConvert.SerializeObject(data);
            var req  = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://reqres.in/api/login";
            var result = string.Empty;
            
            using (var client = new HttpClient())

            {
                var response = await client.PostAsync(url, req);

                if(response.IsSuccessStatusCode)

                {

                    //TODO: Logic APP
                }

                var statusCode = response.StatusCode;
                result = await response.Content.ReadAsStringAsync();
            }

             
        }

    }
}
