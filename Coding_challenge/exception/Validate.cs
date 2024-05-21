using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.exception
{
    internal class Validate
    {
        public Validate() { }
        public bool isValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                // Use MailAddress class to validate email format
                var addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool isSalaryPositive(float salary)
        {
            if (salary > 0)
            {
                return true;
            }
            else
                return false;
        }
        public bool beforeDeadLine(DateTime deadline)
        {
            if(DateTime.Now> deadline)
                return false;
            return true;
        }
    }
}
