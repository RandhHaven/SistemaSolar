namespace SistemaSolar.Controllers
{
    using System;
    using System.Diagnostics;
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
        public IActionResult SistemaSolar(int anios)
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
            return View("DetalleSistemaMeteorologico");
        }

        [HttpGet]
        public ActionResult DetalleSistemaMeteorologico()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
