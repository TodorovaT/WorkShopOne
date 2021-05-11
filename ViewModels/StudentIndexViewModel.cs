using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1.Models;

namespace WorkShop1.ViewModels
{
    public class StudentIndexViewModel
    {
        public IList<Student> Students { get; set; }
        public string StudentIndex { get; set; }
        public string StudentFullName { get; set; }
    }
}
