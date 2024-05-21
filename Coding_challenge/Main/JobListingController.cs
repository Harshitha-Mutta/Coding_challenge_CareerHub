using Coding_challenge.doa.IJob;
using Coding_challenge.doa.IJobImpl;
using Coding_challenge.Entity;
using Coding_challenge.exception;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.Main
{
    internal class JobListingController
    {
        static JobListingRepo jrepo = new JobListingRepo();
        static JobListingService jservice = new JobListingService(jrepo);
        static Validate validate = new Validate();
        public static void JobMenuDisplay()
        {
            bool condition = true;
            while(condition)
            {
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1.Add a Job\n2.Display All Jobs\n3.Exit");
                    
                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid option. Please choose again.");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        AddJob(jservice);
                        break;
                    case 2:
                        ListAllJobs(jservice);
                        break;
                    case 3:
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice...Please Choose again");
                        break;
                }
            }
            
        }
        public static void AddJob(JobListingService jservice)
        {
            try
            {
                Joblisting jobListing = new Joblisting();
                Console.Write("Enter CompanyID (int): ");
                jobListing.companyID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter JobTitle (string): ");
                jobListing.jobTitle = Console.ReadLine();

                Console.Write("Enter JobDescription (string): ");
                jobListing.jobDescription = Console.ReadLine();

                Console.Write("Enter JobLocation (string): ");
                jobListing.jobLocation = Console.ReadLine();

                Console.Write("Enter Salary (decimal): ");
                jobListing.salary = (float)Convert.ToDecimal(Console.ReadLine());
                if(validate.isSalaryPositive(jobListing.salary)==false)
                {
                    throw new Exception("Salary cant be negative");
                }

                Console.Write("Enter JobType (string): ");
                jobListing.jobType = Console.ReadLine();

                Console.Write("Enter PostedDate (DateTime - format: yyyy-MM-dd HH:mm:ss): ");
                jobListing.postedDate = DateTime.Parse(Console.ReadLine());

                jservice.InsertJob(jobListing);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static void ListAllJobs(JobListingService jservice)
        {
            var allJobs=jservice.Getjobs();
            if(allJobs==null|| !allJobs.Any())
            {
                Console.WriteLine("No Jobs Found");
            }
            else
            {
                foreach(var job in allJobs)
                {
                    Console.WriteLine(job.jobID+" | "+job.companyID+" | "+job.jobTitle+" | "+job.jobLocation+" | "+job.jobDescription+" | "+job.postedDate);

                }
            }
        }

    }
}
