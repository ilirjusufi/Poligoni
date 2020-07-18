using Poligoni.BO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Poligoni.DAL
{
    public class listoKlient
    {

        public static List<Users> listoLlientat(int roli, string kerko, string po)
        {
            List<Users> lst = new List<Users>();

            var cnn = DataConnection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            if (po == "p")
            {
                cmd.CommandText = "select UserID,Emri,Mbiemri,Username,Email from Userat where Emri like @kerko";
                cmd.Parameters.AddWithValue("@kerko", kerko);
            }
            else
            if (roli == 3)
                cmd.CommandText = "select UserID,Emri,Mbiemri,Username,Email from Userat where RoliID = 3";
            else
                if (roli == 2)
                cmd.CommandText = "select UserID,Emri,Mbiemri,Username,Email from Userat where RoliID = 2";
            else
                cmd.CommandType = CommandType.Text;
            cnn.Close();
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Users d = new Users();
                d.ID = int.Parse(dr["UserID"].ToString());
                d.Emri = dr["Emri"].ToString();
                d.Mbiemri = dr["Mbiemri"].ToString();
                d.Username = dr["Username"].ToString();
                d.Email = dr["Email"].ToString();

                lst.Add(d);

            }
            cnn.Close();
            return lst;
        }

        public static string fshij(int d)
        {
            var cnn = DataConnection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            //cmd.CommandText = "update from Userat where emri";
            cmd.CommandText = "delete from Userat where UserID = @fshij";
            cmd.Parameters.AddWithValue("@fshij", d);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            cnn.Close();
            cnn.Open();
            return null;
        }

    }
}
