using Coding_challenge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJob
{
    internal class JobListingService
    {
        private readonly IJoblisting _jlRepo;
        public JobListingService(IJoblisting jlRepo)
        {
            _jlRepo = jlRepo;
        }
        public void InsertJob(Joblisting job)
        {
            _jlRepo.InsertJob(job);
        }
        public List<Joblisting> Getjobs()
        {
            return _jlRepo.Getjobs();
        }
    }
}
