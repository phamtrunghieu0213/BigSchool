using BigSchool.Models;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModel
{
    public class CourseViewModels
    {
        [Required]
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set;}

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            var a = this.Date;
            var b = this.Time;
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}