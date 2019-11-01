namespace SistemaSolar.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using AServiceSistemaSolar;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using SistemaSolar.Base;
    using SistemaSolar.Models;

    public class HomeController : SistemaSolarController
    {
        public HomeController(ILogger<HomeController> logger)
        {
            this.OnInitialize(logger);
        }

        public override void OnInitialize(ILogger<HomeController> logger)
        {
            _ISistemaSolarSA = new SistemaSolarSA();
            this._logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SistemaSolar()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpPost]
        public RedirectToActionResult SistemaSolar(int anios)
        {
            try
            {
                base.GetSistemaMeteorologico(anios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return RedirectToAction("DetalleSistemaMeteorologico");
            //return View("DetalleSistemaMeteorologico");
        }

        [HttpGet]
        public ActionResult DetalleSistemaMeteorologico()
        {
            try
            {
                //base.GetSistemaMeteorologico(anios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View(ListaSistemaMeteorologico.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
