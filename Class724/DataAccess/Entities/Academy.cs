using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Class724.DataAccess.Entities
{
    public class Academy:EntityBase
    {
        //نام آموزشگاه
        public string Name { get; set;}
        //حوزه تخصصی
        public string ExpertiseArea { get; set; }
        //ادرس وب سایت
        public string WebsiteAddress { get; set; }
        //شماره ثبت
        public int RegistrationID { get; set; }
        //سال تاسیس
        public DateTime EstablishedyYear { get; set; }
        //شماره همراه
        public int MobileNumber { get; set; }
        //شماره تلفن
        public int PhonNumber { get; set; }
        //استان
        public string State { get; set; }
        //شهر
        public string City { get; set; }
        //ادرس
        public string Address { get; set; }



        //شبکه های اجتماعی
        public string Telegram { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }


        //توضیحات تکمیلی و فیلم رزومه
        public string Other { get; set; }
        
        public string Image { get; set; }
        public List< string> VideoList { get; set; }

        public List<User> ManagerList { get; set; }
        //کلید های خارجی
        public virtual ICollection<Teacher> Teachers { get; set; }
        public static ICollection<Course> Courses { get; set; }


    }
}