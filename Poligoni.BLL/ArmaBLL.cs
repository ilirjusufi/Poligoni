using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poligoni.DAL;
using Poligoni.BO;

namespace Poligoni.BLL
{
    public class ArmaBLL
    {
        private static ArmaDAL ArmaDAL = new ArmaDAL();
       

        public static ArmaBO RegjistroArmen(string emriarmes,int kalibri, int maxplumba)
        {
            return ArmaDAL.RegjistroArmen(emriarmes,kalibri,maxplumba);
        }

        //public static RegjistroPlumbatBO ndryshoArmen(int PlumbiID,int Kalibri,int Sasia)
        //{
        //    return RegjistroPlumbatDAL.ndryshoPlumbat(PlumbiID,Kalibri,Sasia);
        //}


    }
}
