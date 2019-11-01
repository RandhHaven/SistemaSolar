namespace SistemaSolar.Base
{
    using AServiceSistemaSolar;
    #region Directives
    using AServiceSistemaSolar.Interface;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using SistemaSolar.Controllers;
    using SistemaSolar.Models;
    using System;
    using System.Collections.Generic;
    #endregion

    #region Class
    public abstract class SistemaSolarController : Controller
    {
        #region Properties
        public ISistemaSolarSA _ISistemaSolarSA { get; set; }


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

        public List<SistemaMeteorologico> ListaSistemaMeteorologico
        {
            get
            {
                object o = ViewData["ListaSistemaMeteorologico"];
                return (Object.Equals(o, null)) ? new List<SistemaMeteorologico>() : (List<SistemaMeteorologico>)ViewData["ListaSistemaMeteorologico"];
            }
            set
            {
                ViewData["ListaSistemaMeteorologico"] = value;
            }
        }

        public ILogger<HomeController> _logger { get; set; }
        #endregion

        #region Methods
        public abstract void OnInitialize(ILogger<HomeController> logger);
               

        public void GetSistemaMeteorologico(int anios)
        {
            List<SistemaMeteorologico> listSistema = new List<SistemaMeteorologico>();
           
            try
            {
                //_ISistemaSolarSA.ObtenerPeriodosSequia();
                listSistema.Add(new SistemaMeteorologico
                {
                    NombrePlaneta = "Betasoide",
                    PeriodoSequia = 1234,
                    PeriodoLluvia = 230,
                    PeriodoPresionTemperatura = 200,
                    Anios = 100
                });
                listSistema.Add(new SistemaMeteorologico
                {
                    NombrePlaneta = "Ferengi",
                    PeriodoSequia = 234,
                    PeriodoLluvia = 344,
                    PeriodoPresionTemperatura = 200,
                    Anios = 100
                });
                listSistema.Add(new SistemaMeteorologico
                {
                    NombrePlaneta = "Vulcano",
                    PeriodoSequia = 443,
                    PeriodoLluvia = 343,
                    PeriodoPresionTemperatura = 200,
                    Anios = 100
                });
                this.ListaSistemaMeteorologico = listSistema;
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }

        public List<SistemaSolarController> GetSistemaMeteorologicoMappping(List<SistemaSolarController> lista)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }
        #endregion
    }
    #endregion
}
