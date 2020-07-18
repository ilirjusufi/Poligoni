using Poligoni.BO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Poligoni.DAL
{
    public class RegjistroPlumbatDAL
    {
        RegjistroPlumbatBO qo = new RegjistroPlumbatBO();

        public RegjistroPlumbatBO RegjistroPlumbat(int kalibri, int sasia)
        {

            var cnn = DataConnection.GetConnection();

            using (var conn = DataConnection.GetConnection())
            {

                using (var cmd = DataConnection.Command(conn, "usp_regjistroplumba", CommandType.StoredProcedure))
                {

                    DataConnection.AddParameter(cmd, "@Kalibri", kalibri);
                    DataConnection.AddParameter(cmd, "@Sasia", sasia);
                    DataConnection.AddParameter(cmd, "@insertby", UserSession1.CurrentUser.ID);
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }


            //try
            //{
            //    using (var conn = DataConnection.GetConnection())
            //    {
            //        using (var cmd = DataConnection.Command(conn, "insert into Armet (Kalibri,Sasia) values (@kalibri,@sasia)", CommandType.Text))
            //        {
            //            DataConnection.AddParameter(cmd, "@kalibri", kalibri);
            //            DataConnection.AddParameter(cmd, "@sasia", sasia);

            //            using (var reader = cmd.ExecuteReader())
            //            {
            //                RegjistroPlumbatBO result = null;
            //                return result;
            //            }
            //        }
            //    }
            //}
            //catch (Exception e)
            //{

            //    return null;
            //}




        }
        public static List<RegjistroPlumbatBO> ListPlumbat()
        {
            List<RegjistroPlumbatBO> lst = new List<RegjistroPlumbatBO>();

            var cnn = DataConnection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from Plumbat";
            cmd.CommandType = CommandType.Text;
            cnn.Close();
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RegjistroPlumbatBO d = new RegjistroPlumbatBO();
                d.PlumbiID = int.Parse(dr["PlumbiID"].ToString());
                d.Kalibri = int.Parse(dr["Kalibri"].ToString());
                d.Sasia = int.Parse(dr["Sasia"].ToString());

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

            cmd.CommandText = "delete from plumbat where PlumbiID = @plumbiID";
            cmd.Parameters.AddWithValue("@plumbiID", d);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            cnn.Close();
            cnn.Open();
            return null;
        }
        public RegjistroPlumbatBO ndryshoPlumbat(int PlumbiID, int Kalibri, int Sasia)
        {
            var cnn = DataConnection.GetConnection();

            using (var conn = DataConnection.GetConnection())
            {

                using (var cmd = DataConnection.Command(conn, "usp_ndryshoPlumba", CommandType.StoredProcedure))
                {
                    DataConnection.AddParameter(cmd, "@PlumbiID", PlumbiID);
                    DataConnection.AddParameter(cmd, "@Kalibri", Kalibri);
                    DataConnection.AddParameter(cmd, "@Sasia", Sasia);
                    DataConnection.AddParameter(cmd, "@InsertBy", UserSession1.CurrentUser.ID);
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
        }
        public static List<RegjistroPlumbatBO> kerkoPlumbat(string kerko, string po)
        {
            List<RegjistroPlumbatBO> lst = new List<RegjistroPlumbatBO>();

            var cnn = DataConnection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            if (po == "p")
            {
                cmd.CommandText = "select PlumbiID,Kalibri,Sasia from Plumbat where Kalibri like @kerko";
                cmd.Parameters.AddWithValue("@kerko", kerko);
            }
            cmd.CommandType = CommandType.Text;
            cnn.Close();
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RegjistroPlumbatBO d = new RegjistroPlumbatBO();
                d.PlumbiID = int.Parse(dr["PlumbiID"].ToString());
                d.Kalibri = int.Parse(dr["Kalibri"].ToString());
                d.Sasia = int.Parse(dr["Sasia"].ToString());

                lst.Add(d);

            }
            cnn.Close();
            return lst;
        }

    }
}
