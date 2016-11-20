using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Class724.DataAccess.Entities
{
    public class Chapter:EntityBase
    {
        public string ChapterName { get; set; }
        public int Duration { get; set; }
        public List<string> SubChapter { get; set; }
        public List<string> NeedList { get; set; }

        public List<string> ResultList { get; set; } 
    }
}