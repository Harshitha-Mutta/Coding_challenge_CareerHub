using Coding_challenge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJob
{
    internal class ApplicantService
    {
        private readonly IApplicant _ARepo;
        public ApplicantService(IApplicant ARepo)
        {
            _ARepo = ARepo;
        }
        public void CreateProfile(string email, string firstName, string lastName, string phone, string resume)
        {
            _ARepo.CreateProfile(email, firstName, lastName, phone, resume);
        }
        public List<Applicant> GetApplicants()
        {
            return _ARepo.GetApplicants();
        }

    }
}
