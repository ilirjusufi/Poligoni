using Poligoni.BO;
using Poligoni.DAL;

namespace Poligoni.BLL
{
    public class ArmaBLL
    {
        private static ArmaDAL ArmaDAL = new ArmaDAL();



        public static ArmaBO RegjistroArmen(string emriarmes, int kalibri, int maxplumba)
        {
            return ArmaDAL.RegjistroArmen(emriarmes, kalibri, maxplumba);
        }

        public static ArmaBO ndryshoArma(int ArmaID, string emriarmes, string kalibri, int maxplumba)
        {
            return ArmaDAL.ndryshoArma(ArmaID, emriarmes, kalibri, maxplumba);
        }

        //public static RegjistroPlumbatBO ndryshoArmen(int PlumbiID,int Kalibri,int Sasia)
        //{
        //    return RegjistroPlumbatDAL.ndryshoPlumbat(PlumbiID,Kalibri,Sasia);
        //}


    }
}
