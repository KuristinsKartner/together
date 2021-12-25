using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class Note
    {
        string Author { set; get; }
        int Day { set; get; }
        int Month { set; get; }
        int Year { set; get; }
        string Note_event { set; get; }
        string Note_topic { set; get; }
        int Folder { set; get; }
        string Location { set; get; }
        bool Note_public { set; get; }
        string Pic1 { set; get; }
        string Pic2 { set; get; }
        string Pic3 { set; get; }
        string Text_comm { set; get; }
    }
}
