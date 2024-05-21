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
    internal class CompanyController
    {
        static CompanyRepo crepo = new CompanyRepo();
        static CompanyService cservice = new CompanyService(crepo);
        static JobListingRepo jrepo = new JobListingRepo();
        static JobListingService jservice = new JobListingService(jrepo);

        static Validate validate = new Validate();
        public static void CompanyMenuDisplay()
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1.Add a Company\n2.Display All Companies\n3.Exit");

                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid option. Please choose again.");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        AddCompany(cservice);
                        break;
                    case 2:
                        ListAllCompanies(cservice);
                        break;
                    /*case 4:
                        JobListingController.AddJob();
*/
                     case 3:
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice...Please Choose again");
                        break;
                }
            }

        }
        public static void AddCompany(CompanyService cservice)
        {
            try
            {
                Company company = new Company();

                Console.Write("Enter CompanyName (string): ");
                company.companyName = Console.ReadLine();

                Console.Write("Enter Location (string): ");
                company.location = Console.ReadLine();
                cservice.CompanyAdd(company);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ListAllCompanies(CompanyService cservice)
        {
            var allCompanies=cservice.GetCompanies();
            if(allCompanies.Count ==null || !allCompanies.Any())
            {
                Console.WriteLine("No Companies Found");
            }
            else
            {
                foreach(var c in  allCompanies)
                {
                    Console.WriteLine(c.companyId+" | "+c.companyName+" | "+c.location);
                }
            }
        }



    }
}
