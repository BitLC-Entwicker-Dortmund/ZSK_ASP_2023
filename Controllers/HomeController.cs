using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZSK_ASP_2023.Models;

namespace ZSK_ASP_2023.Controllers {
    public class HomeController : Controller {

        public IActionResult Index ( ) {
            return View ( );
        }

        public IActionResult ZSKEingabe ( ) {
            return View ( );
        }

        public IActionResult Berechnung ( string s) {
            int [ ] zsk = ZSKBerechnung.BerechneAnzahlTiere ( s );

            return View ( "Ergebnis", zsk );
        }

        //public IActionResult Index ( string euro ) {
        //    int [ ] zsk = ZSKBerechnung.BerechneAnzahlTiere ( euro );

        //    return View ( "Ergebnis", zsk);
        //}



    }
}
