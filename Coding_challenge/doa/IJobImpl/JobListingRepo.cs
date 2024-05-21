using Coding_challenge.doa.IJob;
using Coding_challenge.Entity;
using Coding_challenge.Util;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.doa.IJobImpl
{
    internal class JobListingRepo : IJoblisting
    {
        DBConnUtil obj = new DBConnUtil();
        public void InsertJob(Joblisting job)
        {
            try
            {
                string query =
                string.Format("insert into Joblisting values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                , job.companyID, job.jobTitle, job.jobDescription, job.jobLocation, job.salary, job.jobType, job.postedDate);
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
        public List<Joblisting> Getjobs()
        {
            try
            {
                SqlConnection con = obj.conObj();
                string query = string.Format("select * from Joblisting");
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                List<Joblisting> JA = new List<Joblisting>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    JA.Add(new Joblisting
                    {
                        jobID = Convert.ToInt32(reader["jobID"]),
                        companyID = Convert.ToInt32(reader["companyID"]),
                        jobTitle = Convert.ToString(reader["jobTitle"]),
                        jobDescription = Convert.ToString(reader["jobDescription"]),
                        jobLocation = Convert.ToString(reader["jobLocation"]),
                        salary = (float)Convert.ToDecimal(reader["salary"]),
                        jobType = Convert.ToString(reader["jobType"]),
                        postedDate = Convert.ToDateTime(reader["postedDate"]),

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
