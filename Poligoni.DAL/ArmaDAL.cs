using Poligoni.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Poligoni.DAL
{
    public class ArmaDAL
    {
        ArmaBO qo = new ArmaBO();

        public ArmaBO RegjistroArmen(string emriarmes, int kalibri, int maxplumba)
        {

            using (var conn = DataConnection.GetConnection())
            {

                using (var cmd = DataConnection.Command(conn, "usp_RegjistroArmen", CommandType.StoredProcedure))
                {

                    DataConnection.AddParameter(cmd, "@EmriArmes", emriarmes);
                    DataConnection.AddParameter(cmd, "@Kalibri", kalibri);
                    DataConnection.AddParameter(cmd, "@MaxPlumba", maxplumba);
                    DataConnection.AddParameter(cmd, "@insertby", UserSession1.CurrentUser.ID);
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
        }

        public ArmaBO ndryshoPlumbat(int PlumbiID, int Kalibri, int Sasia)
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

        public static List<ArmaBO> ListoArmet(string kerko, string po)
        {
            List<ArmaBO> lst = new List<ArmaBO>();

            var cnn = DataConnection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            if (po == "p")
            {
                cmd.CommandText = "select ArmaID,EmriArmes,Kalibri,MaxPlumba from Arma where EmriArmes like @kerko";
                cmd.Parameters.AddWithValue("@kerko", kerko);
            }
            else
                cmd.CommandText = "select ArmaID, EmriArmes,Kalibri,MaxPlumba from Arma";
            cmd.CommandType = CommandType.Text;
            cnn.Close();
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ArmaBO d = new ArmaBO();
                d.ArmaID = Convert.ToInt32(dr["ArmaID"]);
                d.EmriArmes = (dr["EmriArmes"].ToString());
                d.Kalibiri = dr["Kalibri"].ToString();
                d.MaxPlumba = Convert.ToInt32(dr["MaxPlumba"]);
                lst.Add(d);

            }
            cnn.Close();
            return lst;
        }
        public ArmaBO ndryshoArma(int ArmaID, string emriArmes, string Kalibri, int maxPlumba)
        {
            var cnn = DataConnection.GetConnection();

            using (var conn = DataConnection.GetConnection())
            {

                using (var cmd = DataConnection.Command(conn, "usp_ndryshoArma", CommandType.StoredProcedure))
                {
                    DataConnection.AddParameter(cmd, "@ArmaID", ArmaID);
                    DataConnection.AddParameter(cmd, "@EmriArmes", emriArmes);
                    DataConnection.AddParameter(cmd, "@Kalibri", Kalibri);
                    DataConnection.AddParameter(cmd, "@MaxPlumba", maxPlumba);
                    DataConnection.AddParameter(cmd, "@InsertBy", UserSession1.CurrentUser.ID);
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
        }

        public static string fshij(int fshije)
        {
            using (var conn = DataConnection.GetConnection())
            {

                using (var cmd = DataConnection.Command(conn, "usp_fshij", CommandType.StoredProcedure))
                {
                    DataConnection.AddParameter(cmd, "@ArmaID", fshije);

                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
        }

        //public static List<RegjistroPlumbatBO> ListPlumbat()
        //{
        //    List<RegjistroPlumbatBO> lst = new List<RegjistroPlumbatBO>();

        //    var cnn = DataConnection.GetConnection();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cnn;
        //    cmd.CommandText = "select * from Plumbat";
        //    cmd.CommandType = CommandType.Text;
        //    cnn.Close();
        //    cnn.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        RegjistroPlumbatBO d = new RegjistroPlumbatBO();
        //        d.PlumbiID = int.Parse(dr["PlumbiID"].ToString());
        //        d.Kalibri = int.Parse(dr["Kalibri"].ToString());
        //        d.Sasia = int.Parse(dr["Sasia"].ToString());

        //        lst.Add(d);

        //    }
        //    cnn.Close();
        //    return lst;
        //}
        //public static string fshij(int d)
        //{
        //    var cnn = DataConnection.GetConnection();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cnn;
        //    //cmd.CommandText = "update from Userat where emri";
        //    cmd.CommandText = "delete from plumbat where PlumbiID = @plumbiID";
        //    cmd.Parameters.AddWithValue("@plumbiID", d);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.ExecuteScalar();
        //    cnn.Close();
        //    cnn.Open();
        //    return null;
        //}
        //public RegjistroPlumbatBO ndryshoPlumbat(int PlumbiID, int Kalibri, int Sasia)
        //{
        //   var cnn = DataConnection.GetConnection();

        //    using (var conn = DataConnection.GetConnection())
        //    {

        //        using (var cmd = DataConnection.Command(conn, "STOREDPROCEDURA", CommandType.StoredProcedure))
        //        {
        //            DataConnection.AddParameter(cmd, "@userID", PlumbiID);
        //            DataConnection.AddParameter(cmd, "@emri", Kalibri);
        //            DataConnection.AddParameter(cmd, "@mbiemri", Sasia);
        //            cmd.ExecuteNonQuery();
        //            return null;
        //        }
        //    }
        //}
        //public static List<RegjistroPlumbatBO> kerkoPlumbat(string kerko, string po)
        //{
        //    List<RegjistroPlumbatBO> lst = new List<RegjistroPlumbatBO>();

        //    var cnn = DataConnection.GetConnection();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cnn;
        //    if (po == "p")
        //    {
        //        cmd.CommandText = "select PlumbiID,Kalibri,Sasia from Plumbat where Kalibri like @kerko";
        //        cmd.Parameters.AddWithValue("@kerko", kerko);
        //    }
        //    cmd.CommandType = CommandType.Text;
        //    cnn.Close();
        //    cnn.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        RegjistroPlumbatBO d = new RegjistroPlumbatBO();
        //        d.PlumbiID = int.Parse(dr["PlumbiID"].ToString());
        //        d.Kalibri = int.Parse(dr["Kalibri"].ToString());
        //        d.Sasia = int.Parse(dr["Sasia"].ToString());

        //        lst.Add(d);

        //    }
        //    cnn.Close();
        //    return lst;
        //}

    }
}
