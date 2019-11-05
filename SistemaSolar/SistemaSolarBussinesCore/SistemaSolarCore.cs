namespace SistemaSolarBussinesCore
{
    #region Directives
    using EntitySistemaSolar;
    using EntitySistemaSolar.Interfaces;
    using System;
    using System.Collections.Generic;
    #endregion

    #region Class
   
    public class SistemaSolarCore
    {
        public ISistemaSolar unSistemaSolar { get; set; }

        public SistemaSolarCore()
        {
            try
            {
                if(Object.Equals(unSistemaSolar, null))
                {
                    unSistemaSolar = new SistemaSolar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene el listado por Planeta del Sistema Meteorologico de cada planeta en base a la cantidad de años.
        /// </summary>
        /// <param name="anios"></param>
        /// <returns></returns>
        public List<SistemaMeteorologicoBase> GetSistemaSolar(int anios)
        {
            List<SistemaMeteorologicoBase> listSistema = new List<SistemaMeteorologicoBase>();           

            try
            {
                
                unSistemaSolar.Initialize(anios);                
                listSistema = unSistemaSolar.CargarSistemaMeteorologico();
                listSistema.Add(new SistemaMeteorologicoBase
                {
                    Planeta = "Betasoide",
                    PeriodoSequia = 1234,
                    PeriodoLluvia = 230,
                    PeriodoPresionTemperatura = 200,
                    Anios = anios
                });
                listSistema.Add(new SistemaMeteorologicoBase
                {
                    Planeta = "Ferengi",
                    PeriodoSequia = 234,
                    PeriodoLluvia = 344,
                    PeriodoPresionTemperatura = 200,
                    Anios = anios
                });
                listSistema.Add(new SistemaMeteorologicoBase
                {
                    Planeta = "Vulcano",
                    PeriodoSequia = 443,
                    PeriodoLluvia = 343,
                    PeriodoPresionTemperatura = 200,
                    Anios = anios
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listSistema;
        }
    }
    #endregion
}
