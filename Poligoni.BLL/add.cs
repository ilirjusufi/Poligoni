using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poligoni.DAL;
using Poligoni.BO;

namespace Poligoni.BLL
{
   public class add
    {
        private static  UsersDal dal = new UsersDal();



        public static  Users shto (string emri, string mbiemri)
        {
            return dal.shto(emri, mbiemri);
        }
    }
}
