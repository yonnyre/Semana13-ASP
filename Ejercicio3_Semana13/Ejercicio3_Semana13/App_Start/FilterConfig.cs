﻿using System.Web;
using System.Web.Mvc;

namespace Ejercicio3_Semana13
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
