using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.Entity
{
    internal class Joblisting
    {
        public int jobID { get; set; }
        public int companyID { get; set; }
        public string jobTitle { get; set; }
        public string jobDescription { get; set; }
        public string jobLocation { get; set; }
        public float salary { get; set; }
        public string jobType { get; set; }
        public DateTime postedDate { get; set; }
        public Joblisting() { }
        public Joblisting(int jid,int cid,string jtitle,string jdesc,float sal,string jobt,DateTime Pdate)
        {
            jobID=jid;
            companyID=cid;
            jobTitle=jtitle;
            jobDescription=jdesc;
            salary=sal;
            jobType=jobt;
            postedDate=Pdate;
        }
    }
}
