using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model.Emtity;
using System.Data.SqlClient;
namespace model
{
    public class accout
    {
        private Model1 context = null;
        public accout()
        {
            context = new Model1();
        }
        public bool loginn(String u, String p)
        {
            object[] sqlp =
            {
                new SqlParameter("@username",u),
                new SqlParameter("@password",p),
            };
            var res = context.Database.SqlQuery<bool>("admin @username,@password", sqlp).SingleOrDefault();
            return res;
        }
    }
}
