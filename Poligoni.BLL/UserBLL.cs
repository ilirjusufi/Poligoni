using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poligoni.DAL;
using Poligoni.BO;

namespace Poligoni.BLL
{
   public class UserBLL
    {
        private static  UsersDal dal = new UsersDal();
        private static regjistrimiKlientitDAL dalklient = new regjistrimiKlientitDAL();
        public static  Users Login (string Useri, string Passwordi)
        {
            return dal.Login(Useri, Passwordi);
        }

        public static Users RegjistroKlient(string Emri, string Mbiemri,string Username,string Password,string Email)
        {
            return dalklient.RegjistroKlient(Emri, Mbiemri, Username, Password, Email);
        }

        
    }
}
