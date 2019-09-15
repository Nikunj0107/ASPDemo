using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDemo1.Models
{
    public class Member
    {
        public int MembershipID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MembershipType { get; set; }
    }
}