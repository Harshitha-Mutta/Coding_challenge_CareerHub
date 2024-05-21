using Coding_challenge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJob
{
    internal class CompanyService
    {
        private readonly ICompany _CRepo;
        public CompanyService(ICompany CRepo)
        {
            _CRepo = CRepo;
        }
        public void CompanyAdd(Company com)
        {
            _CRepo.AddCompany(com);
        }
        public List<Company> GetCompanies()
        {
            return _CRepo.GetCompanies();
        }


    }
}
