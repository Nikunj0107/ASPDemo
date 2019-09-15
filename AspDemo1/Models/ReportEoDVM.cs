using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDemo1.Models
{
    public class ReportEoDVM
    {
        public Game TopGame { get; set; }

        //public string TopGame { get; set; }
        public List<Member> NewMembers { get; set; }
        public ReportEoDVM()
        {
            NewMembers = new List<Member>();
        }
    }
}