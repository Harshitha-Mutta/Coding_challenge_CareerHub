using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_challenge.exception
{
    internal class BeforeDeadLine:Exception
    {
        public BeforeDeadLine() { }
        public BeforeDeadLine(string message) : base(message) { }
    }
}
