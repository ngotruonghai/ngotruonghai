using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model.Emtity;

namespace model.DAO
{
    public class AccountDAO
    {
        NTHdbContext db = null;
        public AccountDAO()
        {
            db = new NTHdbContext();
        }
       public bool log(String user,String pass)
        {
            var result = db.Taikhoans.Count(x => x.tk == user && x.pass == pass);
            if(result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Taikhoan GetID(String username)
        {
            return db.Taikhoans.SingleOrDefault(x => x.tk == username);
        }
    }
}
