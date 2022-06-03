using System;
using System.Collections.Generic;
using System.Text;
using University.DTOs;
using Xamarin.Forms;

namespace University.ViewModels.Forms
{
    public class CourseItemViewModel : CourseDTO
    {
        async void OnItemClick()
        {
            await Application.Current.MainPage.DisplayAlert("Notify", $"Selected {this.Title}", "Cancel");
        }
        public Command OnItemClickCommand { get; set; }

        public CourseItemViewModel ()
        {
            this.OnItemClickCommand = new Command(OnItemClick);
        }
           

    }
}
