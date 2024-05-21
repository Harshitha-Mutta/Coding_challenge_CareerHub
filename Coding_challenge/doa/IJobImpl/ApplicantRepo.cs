using Coding_challenge.doa.IJob;
using Coding_challenge.Entity;
using Coding_challenge.Util;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJobImpl
{
    internal class ApplicantRepo : IApplicant
    {
        DBConnUtil obj = new DBConnUtil();
        public void CreateProfile(string email, string firstName, string lastName, string phone, string resume)
        {
            try
            {
                string query =
                string.Format("insert into Applicant values('{0}','{1}','{2}','{3}','{4}')", firstName, lastName, email, phone, resume);
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
        public List<Applicant> GetApplicants()
        {
            try
            {
                SqlConnection con = obj.conObj();
                string query = string.Format("select * from Applicant");
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                List<Applicant> JA = new List<Applicant>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    JA.Add(new Applicant
                    {
                        applicantID = Convert.ToInt32(reader["ApplicantID"]),
                        firstName = Convert.ToString(reader["FirstName"]),
                        lastName = Convert.ToString(reader["LastName"]),
                        email = Convert.ToString(reader["Email"]),
                        phone = Convert.ToString(reader["Phone"]),
                        resume = Convert.ToString(reader["Resume"])
                    });
                }
                return JA;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
