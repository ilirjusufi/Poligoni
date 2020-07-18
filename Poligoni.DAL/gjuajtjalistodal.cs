using Poligoni.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Poligoni.DAL
{
    public class gjuajtjalistodal
    {
        public static List<gjuajtja> listoLlientat(string kerko, string po)
        {
            List<gjuajtja> lst = new List<gjuajtja>();

            var cnn = DataConnection.GetConnection();



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from Gjujtja";
            cmd.CommandType = CommandType.Text;
            cnn.Close();
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            cmd.CommandType = CommandType.Text;


            while (dr.Read())
            {
                gjuajtja d = new gjuajtja();
                d.Arma = dr["Arma"].ToString();
                d.distanca = dr["distanca"].ToString();
                d.PiketEshenuara = Convert.ToInt32(dr["PiketEshenuara"].ToString());
                d.klienti = dr["Klienti"].ToString();
                d.plumbashfryzuar = dr["plumbashfryzuar"].ToString();

                lst.Add(d);

            }
            cnn.Close();
            return lst;
        }

        public static string fshij(string Klienti)
        {
            var cnn = DataConnection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "delete from Gjujtja where Klienti = @klientin";
            cmd.Parameters.AddWithValue("@klientin", Klienti);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            cnn.Close();
            cnn.Open();
            return null;
        }



    }

}
