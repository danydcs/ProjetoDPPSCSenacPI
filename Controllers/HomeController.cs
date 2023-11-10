using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Etapa_3.Models;

namespace Etapa_3.Controllers
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
            CadastroRepository teste = new CadastroRepository();
            teste.TestarConexao();
            return View();
        }

         public IActionResult PageASobreDepto()
        {
            return View();
        }

        public IActionResult PageBCorpoDocente()
        {
            return View();
        }

        public IActionResult PageC1LaboratoriosNucleos()
        {
            return View();
        }

        public IActionResult PageCLabDietetica()
        {
            return View();
        }

        public IActionResult PageCLeca()
        {
            return View();
        }

        public IActionResult PageCLepets()
        {
            return View();
        }

        public IActionResult PageCLichss()
        {
            return View();
        }

        public IActionResult PageCNeab()
        {
            return View();
        }

        public IActionResult PageCNepssa()
        {
            return View();
        }

        public IActionResult PageCNpps()
        {
            return View();
        }

        public IActionResult PageD1ProjetosParcerias()
        {
            return View();
        }

        public IActionResult PageDClicPrato()
        {
            return View();
        }

        public IActionResult PageDEscutaHumanizada()
        {
            return View();
        }

        public IActionResult PageDFortalecendoRedes()
        {
            return View();
        }

        public IActionResult PageDNucleoTrans()
        {
            return View();
        }

        public IActionResult PageDNumepi()
        {
            return View();
        }

        public IActionResult PageDObservatorioSaudeSocioAmbiental()
        {
            return View();
        }

        public IActionResult PageDPraticasSociaisUrbanas()
        {
            return View();
        }

        public IActionResult PageDRedeNonConformes()
        {
            return View();
        }

        public IActionResult PageDSaudePelaTerra()
        {
            return View();
        }

        public IActionResult PageE1NoticiasArtigos()
        {
            return View();
        }

         public IActionResult PageECineDebate()
        {
            return View();
        }

         public IActionResult PageEEventoTrabalhoTerritorioESaude()
        {
            return View();
        }

         public IActionResult PageENutricaoConsciencia()
        {
            return View();
        }

         public IActionResult PageEReportagemPopSitRua()
        {
            return View();
        }

        public IActionResult PageF1FaleConosco()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PageF1FaleConosco(FaleConosco msg)
        {
            FaleConoscoRepository fcR = new FaleConoscoRepository();
            fcR.Cadastrar(msg);
            ViewBag.Enviar = "Mensagem Enviada com Sucesso";
            return View();
        }

       

        public IActionResult ProfCarine()
        {
            return View();
        }

        public IActionResult ProfCarlosRoberto()
        {
            return View();
        }

        public IActionResult ProfCristiane()
        {
            return View();
        }

        public IActionResult ProfFernando()
        {
            return View();
        }

        public IActionResult ProfGisele()
        {
            return View();
        }

        public IActionResult ProfJaqueline()
        {
            return View();
        }

        public IActionResult ProfJosiane()
        {
            return View();
        }

        public IActionResult ProfJuarez()
        {
            return View();
        }

        public IActionResult ProfLia()
        {
            return View();
        }

        public IActionResult ProfLuciana()
        {
            return View();
        }

        public IActionResult ProfLuizHenrique()
        {
            return View();
        }

        public IActionResult ProfMacarena()
        {
            return View();
        }

        public IActionResult ProfMariaFernanda()
        {
            return View();
        }

        public IActionResult ProfRosiran()
        {
            return View();
        }

        public IActionResult ProfSemiramis()
        {
            return View();
        }

        public IActionResult ProfTania()
        {
            return View();
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
