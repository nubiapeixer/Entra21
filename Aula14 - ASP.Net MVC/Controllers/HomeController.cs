using Aula_ASP.NET_core.Models;
using BAL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_ASP.NET_core.Controllers
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

        public IActionResult CadastroVaga()
        {
            return View();
        }
        public IActionResult AuthVaga(string placa, string horaEntrada)
        {
            Estacionamento vaga = new Estacionamento
            {
                Placa = placa,
                HoraEntrada = Convert.ToDouble(horaEntrada)
            };
            Response resp = EstacionamentoBAL.Insert(vaga);
            if (resp.Executed)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("CadastroVaga", "Home");
            }
        }
    }
}
