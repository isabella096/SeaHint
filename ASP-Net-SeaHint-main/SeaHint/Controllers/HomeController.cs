using Microsoft.AspNetCore.Mvc;
using SeaHint.Models;
using System.Diagnostics;

namespace SeaHint.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var nPraia = new List<TipoPraia>
            {
                new TipoPraia
                {
                    nomePraia1 = "Praia de Maresias",
                    nomePraia2 = "Praia do Bonete",
                    nomePraia3 = "Praia da Baleia",
                    nomePraia4 = "Praia do Félix",
                    nomePraia5 = " Praia de Tijucopava",
                    nomePraia6 = "Praia do Tombo",
                    nomePraia7 = " Praia de Camburi",
                    nomePraia8 = "Praia do Itambuca",
                    nomePraia9 = "Praia de São Pedro",
                    nomePraia10 = "Praia da Paúba",


                    nomePraia11= "Praia Branca",
                    nomePraia12 = "Praia Preta",
                    nomePraia13 = "Praia de Prumirim",
                    nomePraia14 = "Praia brava de guaecá",
                    nomePraia15 = "Praia da justa",
                    nomePraia16 = "Trilha das 7 praias",
                    nomePraia17 = "Praia de Castelhanos",
                    nomePraia18 = "Praia da Lagoinha",
                    nomePraia19 = "Praia do Flamengo",
                    nomePraia20 = "Praia do Sangava",


                    nomePraia21= "Praia Domingo Dias",
                    nomePraia22 = "Jabaquara",
                    nomePraia23 = "Baía de castelhana",
                    nomePraia24 = "Praia da Enseada",
                    nomePraia25 = "Praia do Tombo",
                    nomePraia26 = "Praia de Camburi",
                    nomePraia27 = "Praia de Itamambuca",
                    nomePraia28 = "Praia de São Pedro",
                    nomePraia29 = "Praia de Tijucopava",
                    nomePraia30 = "Praia do Félix",






                }
            };


            return View(nPraia);

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

