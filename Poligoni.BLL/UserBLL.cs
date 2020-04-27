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
        public static  Users Login (string Useri, string Passwordi)
        {
            return dal.Login(Useri, Passwordi);
        }

        
    }
}
