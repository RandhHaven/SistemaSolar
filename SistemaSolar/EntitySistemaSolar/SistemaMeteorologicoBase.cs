namespace EntitySistemaSolar
{
    #region Directives
    using EntitySistemaSolar.Interfaces;
    using EntitySistemaSolar.Planetas;
    using System;
    #endregion

    #region Clase
    [Serializable]
    public class SistemaMeteorologicoBase
    {
        #region Properties
       
        public string Planeta { get; set; }

        public int PeriodoSequia { get; set; }

        public int PeriodoLluvia { get; set; }

        public int PeriodoPresionTemperatura { get; set; }

        public int Anios { get; set; }
        #endregion

        #region Constructor
        public SistemaMeteorologicoBase()
        {
           
        }
        #endregion
    }
    #endregion
}
