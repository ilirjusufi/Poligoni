using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poligoni.DAL;
using Poligoni.BO;

namespace Poligoni.BLL
{
    public class RegjistroPlumbatBLL
    {
        private static RegjistroPlumbatDAL RegjistroPlumbatDAL = new RegjistroPlumbatDAL();
       

        public static RegjistroPlumbatBO RegjistroKlient(string kalibri, string sasia)
        {
            return RegjistroPlumbatDAL.RegjistroPlumbat(kalibri,sasia);
        }




    }
}
