using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Coding_challenge.Util
{
    internal class DBPropertyUtil
    {
        static string connectionstring;
        public static string conString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var section = builder.GetSection("ConnectionStrings");
            connectionstring = section["SqlConnectionString"];
            //Console.WriteLine(connectionstring);
            return connectionstring;
        }
    }
}
