using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLeituraMatrix.Controllers
{
    public class CardControllers
    {
        public IActionResult Index()
        {
            CardTextoDAO dados = new ResponsavelDAO();
            ViewBag.listaResponsavel = dados.getTodaOsResponsavel();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
