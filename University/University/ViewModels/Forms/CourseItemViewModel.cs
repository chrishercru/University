using System;
using System.Collections.Generic;
using System.Text;
using University.DTOs;
using University.Views.Forms;
using Xamarin.Forms;

namespace University.ViewModels.Forms
{
    public class CourseItemViewModel : CourseDTO
    {
        async void OnItemClick()
        {
            await Application.Current.MainPage.DisplayAlert("Notify", $"Selected {this.Title}", "Cancel");
            CourseDetailPage detailPage = new CourseDetailPage();
            detailPage.BindingContext = new CourseDetailViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(detailPage);
        }
        public Command OnItemClickCommand { get; set; }

        public CourseItemViewModel ()
        {
            this.OnItemClickCommand = new Command(OnItemClick);
        }
           

    }
}
