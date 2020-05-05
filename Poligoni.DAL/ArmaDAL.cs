﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poligoni.BO;

namespace Poligoni.DAL
{
	public class ArmaDAL
	{
        ArmaBO qo = new ArmaBO();
        
        public ArmaBO RegjistroArmen(string emriarmes,int kalibri, int maxplumba)
        {

            var cnn = DataConnection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "insert into Armet (EmriArmes,Kalibri,MaxPlumba) values (@emriarmes,@kalibri,@maxplumba)";
            cmd.Parameters.AddWithValue("@emriarmes", emriarmes);
            cmd.Parameters.AddWithValue("@kalibri", kalibri);
            cmd.Parameters.AddWithValue("@maxplumba", maxplumba);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteScalar();
            cnn.Close();
            cnn.Open();
            return null;
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