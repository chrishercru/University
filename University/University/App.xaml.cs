using System;
using University.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace University
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CoursesPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
