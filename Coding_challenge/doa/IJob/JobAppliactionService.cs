using Coding_challenge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJob
{
    internal class JobAppliactionService
    {
        public readonly IJobApplications _jap;
        public JobAppliactionService(IJobApplications jap)
        {
            _jap = jap;
        }
        public void ApplyForJob(int jid, int aId, string CoverLetter)
        {
            _jap.ApplyForJob(jid, aId, CoverLetter);
        }
        public List<JobApplications> GetJobApplicationsForJob(int jid)
        {
            return _jap.GetJobApplicationsForJob(jid);
        }



    }
}
