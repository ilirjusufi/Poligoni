﻿using Poligoni.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poligoni.DAL;
using System.Net.Http.Headers;

namespace Poligoni.BLL
{

   public class gjuajtjabll
    {
        static gjuajtjadal gjuajtjadal = new gjuajtjadal();
        
        
        public static gjuajtja gjuaje(string a)
        {
            return gjuajtjadal.regjistrogjuajten(a);
        }
    }
}
