using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligoni
{
    public class lidhjainternet
    {
       
        public static bool CheckForInternetConnection()
        {
			try
			{
               
              using (var client = new WebClient())
              using (client.OpenRead("http://google.com/generate_204"))
              return true;
            
            }
			catch (Exception a)
			{
                
                return false;
            }
        }
    }
}
