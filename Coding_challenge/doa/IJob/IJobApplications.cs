using Coding_challenge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJob
{
    internal interface IJobApplications
    {
        public void ApplyForJob(int jid, int aId, string CoverLetter);
        public List<JobApplications> GetJobApplicationsForJob(int jid);

    }
}
