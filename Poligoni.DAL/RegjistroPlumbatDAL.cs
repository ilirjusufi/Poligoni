using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poligoni.BO;

namespace Poligoni.DAL
{
	public class RegjistroPlumbatDAL
	{
        RegjistroPlumbatBO qo = new RegjistroPlumbatBO();
        
        public RegjistroPlumbatBO RegjistroPlumbat(string kalibri, string sasia)
        {
            try
            {
                using (var conn = DataConnection.GetConnection())
                {
                    using (var cmd = DataConnection.Command(conn, "dbo.usp_LoginProcedura", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(cmd, "@kalibri", kalibri);
                        DataConnection.AddParameter(cmd, "@sasia", sasia);

                        using (var reader = cmd.ExecuteReader())
                        {
                            RegjistroPlumbatBO result = null;
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
	}
}
