using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace University.ViewModels.Forms
{
    public class LoginViewModel : BaseViewModel
    {
        #region Attributos
        private string _email;
        private string _password;
        #endregion


        #region propertis
        public string Email
        {

            get { return _email; }
            set { this.SetValue(ref _email, value); }
        }

        public string Password
        {
            get { return _password; }
            set { this.SetValue(ref _password, value); }
        }
        #endregion

        #region methods
        async void Login()

        {
            var data = new { email = this.Email, password = this.Password };
            var json = JsonConvert.SerializeObject(data);
            var req  = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://reqres.in/api/login";
            var result = string.Empty;
            
            using (var client = new HttpClient())

            {
                var response = await client.PostAsync(url, req);

                if(response.IsSuccessStatusCode)
                //TODO: logic APP
                {
                  await Application.Current.MainPage.DisplayAlert("Notify", "Login OK", "Cancel");
                }


                #region comands


                var statusCode = response.StatusCode;
                result = await response.Content.ReadAsStringAsync();

                #endregion}
            }


        }
        #endregion
    }
}
