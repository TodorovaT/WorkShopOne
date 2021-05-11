using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1.Models;

namespace WorkShop1.ViewModels
{
    public class CourseSemesterViewModel
    {
        public IList<Course> Courses { get; set; }
        public SelectList Semesters { get; set; }
        public int CourseSemester { get; set; }
        public SelectList Programmes { get; set; }
        public string CourseProgramme { get; set; }
        public string SearchString { get; set; }
    }
}
