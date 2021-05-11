using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1.Models;

namespace WorkShop1.ViewModels
{
    public class TeacherDegreeViewModel
    {
        public IList<Teacher> Teachers { get; set; }
        public SelectList Degrees { get; set; }
        public int TeacherDegree { get; set; }
        public SelectList AcademicRanks { get; set; }
        public string TeacherAcademicRank { get; set; }
        public string TeacherFullName { get; set; }
    }
}
