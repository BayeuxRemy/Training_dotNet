﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuto_ASP_NET_MVC.Controllers
{
    public class CalculateurController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Calculateur
        public string Ajouter(int valeur1, int valeur2)
        {
            int resultat = valeur1 + valeur2;
            return resultat.ToString();
        }
        public string Soustraire(int valeur1, int valeur2)
        {
            int resultat = valeur1 - valeur2;
            return resultat.ToString();
        }
    }
}