using Poligoni.BO;
using System;
using System.Data.SqlClient;

namespace Poligoni.DAL
{
    public class dashboardStatistikatDAL
    {

        public static dashboardStatistikatBO MerrStatistika()
        {
            dashboardStatistikatBO s = new dashboardStatistikatBO();
            SqlConnection lidhe = new SqlConnection(DataConnection.sqllidhja);
            lidhe.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from Userat", lidhe);
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) from Gjujtja;", lidhe);
            SqlCommand cmd2 = new SqlCommand("select sum(sasia) from plumbat", lidhe);
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) from Arma", lidhe);
            SqlCommand cmd4 = new SqlCommand("SELECT count(*) FROM Userat WHERE MONTH(InsertDate)=MONTH(GETDATE()) ", lidhe);
            SqlCommand cmd5 = new SqlCommand("SELECT count(*) FROM Gjujtja WHERE MONTH(InsertDate)=MONTH(GETDATE())", lidhe);

            object temp = cmd.ExecuteScalar();
            Object temp1 = cmd1.ExecuteScalar();
            Object temp2 = cmd2.ExecuteScalar();
            Object temp3 = cmd3.ExecuteScalar();
            Object temp4 = cmd4.ExecuteScalar();
            Object temp5 = cmd5.ExecuteScalar();
            s.klientateRegjistrua = Convert.ToInt32(temp);
            s.gjuajtjaTotale = Convert.ToInt32(temp1);
            s.plumbaStok = Convert.ToInt32(temp2);
            s.armeRegjisstruar = Convert.ToInt32(temp3);
            s.Klientatmuaj = Convert.ToInt32(temp4);
            s.Gjuajtjamuaj = Convert.ToInt32(temp5);
            lidhe.Close();
            return s;
        }
    }



}
