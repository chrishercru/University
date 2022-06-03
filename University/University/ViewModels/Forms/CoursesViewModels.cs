using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using University.DTOs;
using System.Text;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace University.ViewModels.Forms
{
    public class CoursesViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<CourseItemViewModel> _courses;
        private bool _isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<CourseItemViewModel> Courses
        {
            get { return _courses; }
            set { this.SetValue(ref _courses, value); }
        }

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set { this.SetValue(ref _isRefreshing, value); }
        }
        #endregion

        #region Methods
        async void GetCourses()
        {
            this.IsRefreshing = true;
            var url = "https://apimocha.com/universitycshc/api/Courses";
            var result = string.Empty;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var courses = JsonConvert.DeserializeObject<ObservableCollection<CourseItemViewModel>>(result);
                    this.Courses = courses;
                }
            }
            this.IsRefreshing = false;
        }
        #endregion

        #region Commands
        public Command RefreshCommand { get; set; }
        #endregion

        public CoursesViewModel()
        {
            this.RefreshCommand = new Command(GetCourses);
            this.RefreshCommand.Execute(null);
        }
    }
}
