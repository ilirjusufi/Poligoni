﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligoni.BO
{
    public class Users
    {
        public int ID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public int roliID { get; set; }
        public int MyProperty { get; set; }

        public DateTime InsertDate { get; set; }

        public virtual UserRole UserRole { get; set; } // konvente duhet me qene virtuale
    }
}