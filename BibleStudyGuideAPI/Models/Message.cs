using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibleStudyGuideAPI.Models
{
    public class Message
    {
        //[Key]
        public int MessageID { get; set; }
        public string AuthorName { get; set; }
        public string BookName { get; set; }
        public int ChapterNumber { get; set; }
        public string Date { get; set; }
        public string Message1 { get; set; }
        public string Status { get; set; }
    }
}
