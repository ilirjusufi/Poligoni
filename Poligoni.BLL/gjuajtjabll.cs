using Poligoni.BO;
using Poligoni.DAL;

namespace Poligoni.BLL
{

    public class gjuajtjabll
    {
        static gjuajtjadal gjuajtjadal = new gjuajtjadal();


        public static gjuajtja gjuaje(string kalbri, string distanca, string maxplumba, string klienti, string Arma)
        {
            return gjuajtjadal.regjistrogjuajten(kalbri, distanca, maxplumba, klienti, Arma);
        }


        public static gjuajtja ndryshogjuajte(string klienti, string Arma, string distanca, string plumbashfryzuar, int PiketEshenuara)
        {
            return gjuajtjadal.editoGjuajtje(klienti, Arma, distanca, plumbashfryzuar, PiketEshenuara);
        }
    }
}
