using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class Note
    {
        public string Author { set; get; }
        public int Day { set; get; }
        public int Month { set; get; }
        public int Year { set; get; }
        public string Note_event { set; get; }
        public string Note_topic { set; get; }
        public int Folder { set; get; }
        public string Location { set; get; }
        public bool Note_public { set; get; }
        public string Pic1 { set; get; }
        public string Pic2 { set; get; }
        public string Pic3 { set; get; }
        public string Text_comm { set; get; }
    }
}
