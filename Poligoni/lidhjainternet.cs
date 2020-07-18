using System;
using System.Net;

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
#pragma warning disable CS0168 // The variable 'a' is declared but never used
            catch (Exception a)
#pragma warning restore CS0168 // The variable 'a' is declared but never used
            {

                return false;
            }
        }
    }
}
