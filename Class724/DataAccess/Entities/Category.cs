using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Class724.DataAccess.Entities
{
    public class Category:EntityBase
    {
        public string Name { get; set; }
        public Category Father { get; set; }
        public List<Category> Childs { get; set; }
        public string About { get; set; }
    }

}