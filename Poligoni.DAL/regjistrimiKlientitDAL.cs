using Poligoni.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Poligoni;




namespace Poligoni.DAL
{
    public class regjistrimiKlientitDAL
    {
        UsersDal dal = new UsersDal();
        Users users = new Users();
        

        public Users RegjistroKlient(string Emri, string Mbiemri, string Username, string Password, string Email,int roli)
        {
           


                using (var conn = DataConnection.GetConnection())
                {
                     
                    using (var cmd = DataConnection.Command(conn, "dbo.usp_regjistroklient", CommandType.StoredProcedure))
                    {
                        
                        DataConnection.AddParameter(cmd, "@emri", Emri);
                        DataConnection.AddParameter(cmd, "@mbiemri", Mbiemri);
                        DataConnection.AddParameter(cmd, "@username", Username);
                        DataConnection.AddParameter(cmd, "@password", Password);
                        DataConnection.AddParameter(cmd, "@email", Email);
                        DataConnection.AddParameter(cmd, "@insertby", UserSession1.CurrentUser.ID);
                        DataConnection.AddParameter(cmd, "@insertdate", DateTime.Now);
                        DataConnection.AddParameter(cmd, "@roliID", roli);
                    

                    cmd.ExecuteNonQuery();
                        
                        return null;
                    }


               
                }

           

        }
        public Users editoKlient(int userID, string Emri, string Mbiemri, string Username, string Email)
        {

            var cnn = DataConnection.GetConnection();

            using (var conn = DataConnection.GetConnection())
            {

                using (var cmd = DataConnection.Command(conn, "dbo.usp_editoklient", CommandType.StoredProcedure))
                {
                    DataConnection.AddParameter(cmd, "@userID", userID);
                    DataConnection.AddParameter(cmd, "@emri", Emri);
                    DataConnection.AddParameter(cmd, "@mbiemri", Mbiemri);
                    DataConnection.AddParameter(cmd, "@username", Username);
                    DataConnection.AddParameter(cmd, "@email", Email);
                    cmd.ExecuteNonQuery();
                    return users;



                }



            }
        }

        public Users ToObject(SqlDataReader reader)
        {
            Users user = new Users();
            user.ID = int.Parse(reader["UserID"].ToString());
            user.Username = reader["Username"].ToString();
            //if (reader["EmployeeID"] != DBNull.Value)
            //    user.ID = int.Parse(reader["EmployeeID"].ToString());
            user.UserRoleID = int.Parse(reader["RoliID"].ToString());
            //if (reader["LastLoginDate"] != DBNull.Value)
            //user.LastLoginDate = (DateTime)reader["LastLoginDate"];

            //if (reader["LastPasswordChangeDate"] != DBNull.Value)
            //    user.LastPasswordChangeDate = (DateTime)reader["LastPasswordChangeDate"];

            //if (reader["IsPasswordChanged"] != DBNull.Value)
            //    user.IsPasswordChanged = reader["IsPasswordChanged"].ToString() == "1";

            //user.insertBy = reader["InsertBy"].ToString();
            //user.InsertDate = (DateTime)reader["InsertDate"];
            //update

            return user;

        }

    }
}
