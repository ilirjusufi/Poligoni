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
    }
}
