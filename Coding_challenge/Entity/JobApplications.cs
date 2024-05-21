using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.Entity
{
    internal class JobApplications
    {

        public int applicationID { get; set; }
        public int jobID { get; set; }
        public int applicantID { get; set; }
        public DateTime applicationDate { get; set; }
        public string coverLetter { get; set; }
        public JobApplications() { }
        public JobApplications(int applicationID, int jobID, int applicantID, DateTime applicationDate, string coverLetter)
        {
            this.applicationID = applicationID;
            this.jobID = jobID;
            this.applicantID = applicantID;
            this.applicationDate = applicationDate;
            this.coverLetter = coverLetter;
        }

    }
}
