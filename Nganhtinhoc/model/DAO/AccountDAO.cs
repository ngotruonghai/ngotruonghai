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
        Model1 db = null;
        public AccountDAO()
        {
            db = new Model1();
        }
        public bool LoginGV(String u,String p)
        {
            var result = db.Giaovien.Count(x => x.magiaovien == u && x.pass == p);
            if(result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Giaovien GetID_GV(String username)
        {
            return db.Giaovien.SingleOrDefault(x => x.magiaovien == username);
        }
        public bool logSV(string u,string p)
        {
            var result = db.Sinhvien.Count(x => x.masinhvien == u && x.pass == p);
                if(result > 0)
            {
                return true;
            }
                else
            {
                return false;
            }
        }
       public bool log(String user,String pass)
        {
            var result = db.Taikhoan.Count(x => x.tk == user && x.pass == pass);
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
            return db.Taikhoan.SingleOrDefault(x => x.tk == username);
        }
    }
}
