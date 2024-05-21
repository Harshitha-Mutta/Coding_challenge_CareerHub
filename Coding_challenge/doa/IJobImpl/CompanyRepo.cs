using Coding_challenge.doa.IJob;
using Coding_challenge.Entity;
using Coding_challenge.Util;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJobImpl
{
    internal class CompanyRepo : ICompany
    {
        DBConnUtil obj = new DBConnUtil();
        public void AddCompany(Company com)
        {
            try
            {
                string query =
                string.Format("insert into Company values('{0}','{1}')", com.companyName, com.location);
                SqlConnection con = obj.conObj();
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                Console.WriteLine(n + " rows affected Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<Company> GetCompanies()
        {
            try
            {
                SqlConnection con = obj.conObj();
                string query = "select * from Company";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                List<Company> Companies = new List<Company>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Companies.Add(new Company
                    {
                        companyId = Convert.ToInt32(reader["CompanyID"]),
                        companyName = Convert.ToString(reader["CompanyName"]),
                        location = Convert.ToString(reader["Location"])
                    });
                }
                return Companies;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }
    }
}
