using Coding_challenge.doa.IJob;
using Coding_challenge.doa.IJobImpl;
using Coding_challenge.exception;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.Main
{
    internal class JobApplicationController
    {
        static JobApplicationsRepo jrepo = new JobApplicationsRepo();
        static JobAppliactionService jservice = new JobAppliactionService(jrepo);
        static Validate validate = new Validate();
        public static void JobApplicationMenuDisplay()
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1.Submit an Applicants\n2.Display All Applications\n3.Exit");

                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid option. Please choose again.");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        Add(jservice);
                        break;
                    case 2:
                        ListAll(jservice);
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
        public static void Add(JobAppliactionService jservice)
        {
            try
            {
                Console.WriteLine("Enter Job Id");
                if (!int.TryParse(Console.ReadLine(), out int jid))
                {
                    Console.WriteLine("Invalid Job ID. Please enter a valid number.");
                    return;
                }
                Console.WriteLine("Enter Applicant ID");
                if (!int.TryParse(Console.ReadLine(), out int aid))
                {
                    Console.WriteLine("Invalid Applicant ID. Please enter a valid number.");
                    return;
                }
                Console.WriteLine("Write cover letter");
                string coverL=Console.ReadLine();
                jservice.ApplyForJob(jid,aid,coverL);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ListAll(JobAppliactionService jservice)
        {
            Console.WriteLine("Enter job ID");
            if (!int.TryParse(Console.ReadLine(), out int jid))
            {
                Console.WriteLine("Invalid Job ID. Please enter a valid number.");
                return;
            }
            var allApplications = jservice.GetJobApplicationsForJob(jid);
            if(allApplications==null || !allApplications.Any())
            {
                Console.WriteLine("No applications");
            }
            else
            {
                foreach(var app in allApplications)
                {
                    Console.WriteLine(app.applicationID + " | " + app.jobID + " | " + app.applicantID + " | " + app.applicationDate + " | " + app.coverLetter);
                }
            }
        }

    }
}
