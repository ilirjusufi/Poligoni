﻿using System;
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

      
    }


}
