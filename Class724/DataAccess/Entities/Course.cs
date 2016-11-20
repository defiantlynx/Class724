using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI.WebControls.Expressions;

namespace Class724.DataAccess.Entities
{
    public class Course:EntityBase
    {
        public string Name { get; set; }
        public string About { get; set; }
        public List<Chapter> ChapterList { get; set; }

        public DateTime RegistrationStart { get; set; }
        public DateTime RegistrationEnd { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }

        public int Capacity { get; set; }
        public string Certification { get; set; }
        public int CourseType { get; set; }
         
        public User Teacher { get; set; }
        public List<Category> Categories { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public List<string> Tags { get; set; }
        public string Other { get; set; }
    }
}