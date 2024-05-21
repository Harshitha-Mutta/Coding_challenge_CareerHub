using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coding_challenge.Entity;

namespace Coding_challenge.doa.IJob
{
    internal interface ICompany
    {
        public void AddCompany(Company com);
        public List<Company> GetCompanies();


    }
}
