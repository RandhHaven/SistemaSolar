namespace SistemaSolar.Base
{
    using AServiceSistemaSolar.Interface;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using SistemaSolar.Controllers;
    using SistemaSolar.Models;
    using System;
    using System.Collections.Generic;

    public abstract class SistemaSolarController : Controller
    {
        #region Properties
        ISistemaSolarSA _ISistemaSolarSA { get; set; }

        public SistemaMeteorologico UnSistema
        {
            get
            {
                object o = ViewData["UnSistema"];

                return (Object.Equals(o, null)) ? new SistemaMeteorologico() : (SistemaMeteorologico)ViewData["UnSistema"];
            }
            set
            {
                ViewData["UnSistema"] = value;
            }
        }

        public ILogger<HomeController> _logger { get; set; }
        #endregion

        #region Methods
        public abstract void OnInitialize(ILogger<HomeController> logger);

        public List<SistemaSolarController> GetSistemaMeteorologico(int anios)
        {
            try
            {
                _ISistemaSolarSA.ObtenerPeriodosSequia();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return new List<SistemaSolarController>();
        }
        #endregion
    }
}
