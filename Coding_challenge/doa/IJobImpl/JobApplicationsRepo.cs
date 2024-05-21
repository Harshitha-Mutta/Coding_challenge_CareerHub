using Coding_challenge.doa.IJob;
using Coding_challenge.Entity;
using Coding_challenge.Util;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJobImpl
{
    internal class JobApplicationsRepo : IJobApplications
    {
        DBConnUtil obj = new DBConnUtil();
        public void ApplyForJob(int jid, int aId, string CoverLetter)
        {
            try
            {
                string query =
                string.Format("insert into JobApplications values('{0}','{1}','{2}','{3}')", jid, aId, DateTime.Now, CoverLetter);
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
        public List<JobApplications> GetJobApplicationsForJob(int jid)
        {
            try
            {
                SqlConnection con = obj.conObj();
                string query = string.Format("select * from JobApplications where JobID={0}", jid);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                List<JobApplications> JA = new List<JobApplications>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    JA.Add(new JobApplications
                    {
                        applicationID = Convert.ToInt32(reader["ApplicationID"]),
                        jobID = Convert.ToInt32(reader["JobID"]),
                        applicantID = Convert.ToInt32(reader["ApplicantID"]),
                        applicationDate = Convert.ToDateTime(reader["ApplicationDate"]),
                        coverLetter = Convert.ToString(reader["CoverLetter"])
                    });
                }
                return JA;

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
