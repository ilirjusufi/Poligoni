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

        public Users Login(string Useri, string Passwordi)
        {
            try
            {
                using (var conn = DataConnection.GetConnection())
                {
                    using (var cmd = DataConnection.Command(conn, "dbo.usp_LoginProcedura", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(cmd, "@Username", Useri);
                        DataConnection.AddParameter(cmd, "@Password", Passwordi);

                        using (var reader = cmd.ExecuteReader())
                        {
                            Users result = null;
                            if (reader.Read())
                            {
                                result = ToObject(reader);
                            }

                            return result;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                
                return null;
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
