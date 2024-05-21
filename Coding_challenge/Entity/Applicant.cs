using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.Entity
{
    internal class Applicant
    {
        public int applicantID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string resume { get; set; }
        public Applicant() { }
        public Applicant(int applicantID, string firstName, string lastName, string email, string phone, string resume)
        {
            this.applicantID = applicantID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.resume = resume;
        }

    }
}
