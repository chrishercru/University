using System;
using System.Collections.Generic;
using System.Text;
using University.DTOs;

namespace University.ViewModels.Forms
{
    public class CourseDetailViewModel : BaseViewModel
    {
        private CourseDTO _course;

        public CourseDTO Course

        {
            get { return _course; }
            set { this.SetValue(ref _course, value); }
        }

        public CourseDetailViewModel(CourseDTO course)
        {
            this.Course = course;
        }
        public CourseDetailViewModel()
        {

        }
    }
}
