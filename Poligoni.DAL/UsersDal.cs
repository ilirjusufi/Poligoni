using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poligoni.BO;

namespace Poligoni.DAL
{
    public class UsersDal
    {
        Users qo = new Users();

        public Users shto(string emri, string mbiemri)
        {
            SqlConnection sqlConn = new SqlConnection(DataConnection.sqllidhja);
            sqlConn.Open();
            SqlCommand sqlComm = new SqlCommand("shtoklient", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@Emri", emri);
            sqlComm.Parameters.AddWithValue("@Mbiemri", mbiemri);



            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            
            return null;
           
        }



    }
}
