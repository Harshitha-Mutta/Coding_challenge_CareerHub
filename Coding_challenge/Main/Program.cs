using System.Diagnostics;
using Coding_challenge.Main;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Career Hub");
        Console.WriteLine("--------------------------");
        bool condition = true;
        while (condition)
        {
            Console.WriteLine("Select Your option");
            Console.WriteLine("1.Browse Job Listing\n2.Company\n3.Applicants\n4.Job Applications\n5.Exit");
            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option. Please choose again.");
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.Clear();
                    JobListingController.JobMenuDisplay();
                    break;
                case 2:
                    Console.Clear();
                    CompanyController.CompanyMenuDisplay();
                    break;
                case 3:
                    Console.Clear();
                    ApplicantController.ApplicantMenuDisplay();
                    break;
                case 4:
                    Console.Clear();
                    JobApplicationController.JobApplicationMenuDisplay();
                    break;
                case 5:
                    condition = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }

        }
    }
}