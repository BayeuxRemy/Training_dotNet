﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuto_ASP_NET_MVC.Controllers
{
    public class MeteoController : Controller
    {
        // GET: Meteo
        public string Afficher(int jour, int mois, int annee)
        {
            return "Il fait soleil le " + jour + "/" + mois + "/" + annee;
        }
    }
}