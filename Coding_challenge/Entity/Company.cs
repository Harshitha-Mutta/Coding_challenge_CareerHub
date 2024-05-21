using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.Entity
{
    internal class Company
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
        public string location { get; set; }
        public Company() { }
        public Company(int cid,string cname,string loc) 
        {
            companyId = cid;
            companyName = cname;
            location = loc;
        }
    }
}
