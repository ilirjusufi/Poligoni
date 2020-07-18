using Poligoni.BO;
using System.Data;

namespace Poligoni.DAL
{
    public class gjuajtjadal
    {
        gjuajtja ngarko = new gjuajtja();
        public gjuajtja regjistrogjuajten(string kalbri, string distanca, string maxplumba, string klienti, string Arma)
        {

            using (var conn = DataConnection.GetConnection())
            {

                using (var cmd = DataConnection.Command(conn, "usp_Gjuajtja", CommandType.StoredProcedure))
                {

                    DataConnection.AddParameter(cmd, "@Aarma", Arma);
                    DataConnection.AddParameter(cmd, "@klienti", klienti);
                    DataConnection.AddParameter(cmd, "@Distanca", distanca);
                    DataConnection.AddParameter(cmd, "@pshenuara", kalbri);
                    DataConnection.AddParameter(cmd, "@plumbashfryzuar", maxplumba);
                    DataConnection.AddParameter(cmd, "@insertby", UserSession1.CurrentUser.ID);
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }

        }

        public gjuajtja editoGjuajtje(string klienti, string Arma, string distanca, string plumbashfryzuar, int PiketEshenuara)
        {
            var cnn = DataConnection.GetConnection();

            using (var conn = DataConnection.GetConnection())
            {

                using (var cmd = DataConnection.Command(conn, "usp_editpGjuajtja", CommandType.StoredProcedure))
                {
                    DataConnection.AddParameter(cmd, "@Aarma", Arma);
                    DataConnection.AddParameter(cmd, "@klienti", klienti);
                    DataConnection.AddParameter(cmd, "@Distanca", distanca);
                    DataConnection.AddParameter(cmd, "@pshenuara", PiketEshenuara);
                    DataConnection.AddParameter(cmd, "@plumbashfryzuar", plumbashfryzuar);
                    DataConnection.AddParameter(cmd, "@insertby", UserSession1.CurrentUser.ID);
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
        }


    }


}
