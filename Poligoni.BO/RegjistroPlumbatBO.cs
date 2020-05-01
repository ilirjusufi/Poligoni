using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligoni.BO
{
	public class RegjistroPlumbatBO
    {
            public int ID { get; set; }
            public string Emri { get; set; }
            public string Mbiemri { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public string Email { get; set; }

            public DateTime LastLoginDate { get; set; }
            public string insertBy { get; set; }
            public DateTime InsertDate { get; set; }
            
            public string LUB { get; set; }
            public string LUD { get; set; }
            public string LUN { get; set; } 
        
    }

}
