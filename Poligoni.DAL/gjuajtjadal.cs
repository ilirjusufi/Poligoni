using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Poligoni.BO;

namespace Poligoni.DAL
{
    public class gjuajtjadal
    {
        gjuajtja ngarko = new gjuajtja();
        public gjuajtja regjistrogjuajten(string a)
        {

            using (var conn = DataConnection.GetConnection())
            {

                using (var cmd = DataConnection.Command(conn, "usp_Gjuajtja", CommandType.StoredProcedure))
                {

                    DataConnection.AddParameter(cmd, "@Aarma", gjuajtja.Arma);
                    DataConnection.AddParameter(cmd, "@klienti", gjuajtja.klienti);
                    DataConnection.AddParameter(cmd, "@Distanca", gjuajtja.distanca);
                    DataConnection.AddParameter(cmd, "@pshenuara", gjuajtja.kalbri);
                    DataConnection.AddParameter(cmd, "@plumbashfryzuar", gjuajtja.maxplumba);
                    DataConnection.AddParameter(cmd, "@insertby", UserSession1.CurrentUser.ID);
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
        }
    }
}
