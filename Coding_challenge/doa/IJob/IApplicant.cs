using Coding_challenge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJob
{
    internal interface IApplicant
    {
        public void CreateProfile(string email, string firstName, string lastName, string phone, string resume);
        public List<Applicant> GetApplicants();

    }

}
