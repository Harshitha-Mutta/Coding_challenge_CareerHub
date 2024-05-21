using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.exception
{
    internal class InvalidEmail:Exception
    {
        public InvalidEmail() { }
        public InvalidEmail(string message) : base(message) { }
    }
}
