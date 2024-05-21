using Coding_challenge.doa.IJob;
using Coding_challenge.doa.IJobImpl;
using Coding_challenge.Entity;
using Coding_challenge.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.Main
{
    internal class ApplicantController
    {
        static ApplicantRepo arepo = new ApplicantRepo();
        static ApplicantService aservice = new ApplicantService(arepo);
        static Validate validate = new Validate();
        public static void ApplicantMenuDisplay()
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1.New Applicant\n2.Display All Applicants\n3.Exit");

                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid option. Please choose again.");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        AddApplicant(aservice);
                        break;
                    case 2:
                        ListAllApplicant(aservice);
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
        public static void AddApplicant(ApplicantService aservice)
        {
            try
            {
                Console.WriteLine("ENter Firstname");
                string fn = Console.ReadLine();
                Console.WriteLine("Enter LastName");
                string ln=Console.ReadLine();
                Console.WriteLine("Enter Email");
                string email=Console.ReadLine();
                if(validate.isValidEmail(email)==false)
                {
                    throw new InvalidEmail("Mail is not valid");
                }
                Console.WriteLine("Enter Phone Number");
                string phone=Console.ReadLine();
                Console.WriteLine("Enter Resume file name");
                string resume=Console.ReadLine();
                aservice.CreateProfile(email, fn,ln,phone, resume);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ListAllApplicant(ApplicantService aservice)
        {
            var allApplicants=aservice.GetApplicants();
            if(!allApplicants.Any() || allApplicants==null) 
            {
                Console.WriteLine("No applicants Found");
            }
            else
            {
                foreach(var app in allApplicants)
                {
                    Console.WriteLine(app.applicantID + " | " + app.firstName + " | " + app.lastName + " | " + app.email + " | " + app.phone + " | " + app.resume);
                }
            }
        }

    }
}
