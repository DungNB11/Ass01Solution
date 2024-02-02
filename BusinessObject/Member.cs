using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email
        {
            get;set;
        }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Member()
        {
            
        }

        public Member(int memberID, string memberName, string email, string password, string city, string country)
        {
            MemberID = memberID;
            MemberName = memberName;
            Email = email;
            Password = password;
            City = city;
            Country = country;
        }
        private bool IsValidGmailEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
