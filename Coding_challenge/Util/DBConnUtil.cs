using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Coding_challenge.Util
{
    internal class DBConnUtil
    {
        String constr = DBPropertyUtil.conString();

        public SqlConnection conObj()
        {
            var con = new SqlConnection(constr);
            return con;
        }
    }
}
