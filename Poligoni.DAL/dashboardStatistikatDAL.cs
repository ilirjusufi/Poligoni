using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poligoni.BO;

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
            object temp = cmd.ExecuteScalar();
            Object temp1 = cmd1.ExecuteScalar();
            Object temp2 = cmd2.ExecuteScalar();
            s.klientateRegjistrua = Convert.ToInt32(temp);
            s.gjuajtjaTotale = Convert.ToInt32(temp1);
            s.plumbaStok = Convert.ToInt32(temp2);
            lidhe.Close();
            return s;

            
        }
    }
            

    
}
