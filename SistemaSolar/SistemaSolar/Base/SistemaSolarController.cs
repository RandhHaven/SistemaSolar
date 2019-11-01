namespace SistemaSolar.Base
{
    #region Directives
    using AServiceSistemaSolar.Interface;
    using EntitySistemaSolar;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using SistemaSolar.Controllers;
    using SistemaSolar.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
                object o = TempData["UnSistema"];               
                return (Object.Equals(o, null)) ? new SistemaMeteorologico() : (SistemaMeteorologico)TempData["UnSistema"];
            }
            set
            {
                TempData["UnSistema"] = value;
            }
        }

        public List<SistemaMeteorologico> ListaSistemaMeteorologico
        {
            get
            {
                object o = TempData["ListaSistemaMeteorologico"];
                return (Object.Equals(o, null)) ? new List<SistemaMeteorologico>() : (List<SistemaMeteorologico>)TempData["ListaSistemaMeteorologico"];
            }
            set
            {
                TempData["ListaSistemaMeteorologico"] = value;
            }
        }

        public ILogger<HomeController> _logger { get; set; }
        #endregion

        #region Methods
        public abstract void OnInitialize(ILogger<HomeController> logger);

        public void CargarTiempoEvaluar(int anios)
        {
            UnSistema.Anios = anios;
        }

        public List<SistemaMeteorologico> GetSistemaMeteorologico()
        {
            List<SistemaMeteorologico> listSistema = new List<SistemaMeteorologico>();
            try
            {
                List<SistemaMeteorologicoBase> listSistemaBase = _ISistemaSolarSA.ObtenerSistemaMeteorologico(UnSistema.Anios);

                this.GetSistemaMeteorologicoMappping(listSistemaBase, ref listSistema);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return listSistema;
        }

        public void GetSistemaMeteorologicoMappping(List<SistemaMeteorologicoBase> listaBase,
             ref List<SistemaMeteorologico> lista)
        {
            try
            {
                if (!Object.Equals(listaBase, null) && listaBase.Any())
                {
                    lista = listaBase.ConvertAll(sist => new SistemaMeteorologico
                    {
                        NombrePlaneta = sist.Planeta,
                        PeriodoLluvia = sist.PeriodoLluvia,
                        PeriodoSequia = sist.PeriodoSequia,
                        PeriodoPresionTemperatura = sist.PeriodoPresionTemperatura,
                        Anios = sist.Anios
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
    #endregion
}
