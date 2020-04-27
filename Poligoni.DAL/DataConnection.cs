using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Poligoni.DAL
{
     class DataConnection
    {
        public static string sqllidhja
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Poligoni.Properties.Settings.poligoniConnectionString"].ConnectionString;
            }
         
            
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(sqllidhja);
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public static SqlCommand Command(SqlConnection connection, string cmdText, CommandType commandType)
        {
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandType = commandType;
            return command;
        }

        public static void AddParameter(SqlCommand command, string parameterName, object value)
        {
            SqlParameter parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            if (value != null)
            {
                if (value is DateTime)
                {
                    //mos me leju data me te vogel se sa 1900
                    if (DateTime.Parse(value.ToString()) <= DateTime.Parse("1/01/1900"))
                        value = null;
                }

            }

            parameter.Value = value ?? DBNull.Value;
            command.Parameters.Add(parameter);
            }
        }
}
