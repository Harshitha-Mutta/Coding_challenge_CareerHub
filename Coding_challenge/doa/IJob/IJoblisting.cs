using Coding_challenge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJob
{
    internal interface IJoblisting
    {
        public void InsertJob(Joblisting job);
        public List<Joblisting> Getjobs();
    }
}
