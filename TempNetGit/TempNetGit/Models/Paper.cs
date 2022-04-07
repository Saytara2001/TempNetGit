using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempNetGit.Models
{
    public class Paper
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string filePath { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}