using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.emtity;
using System.Data.SqlClient;

namespace ClassLibrary1
{
        public class accout
    {
        public NTHdbContext context = null;
        public accout()
        {
            context = new NTHdbContext();
        }
        public bool loginn(String u, String p)
        {
            object[] sqlp =
            {
                new SqlParameter("@username",u),
                new SqlParameter("@password",p),
            };
            var res = context.Database.SqlQuery<bool>("login @username,@password", sqlp).SingleOrDefault();
            return res;
        }
    }
}
