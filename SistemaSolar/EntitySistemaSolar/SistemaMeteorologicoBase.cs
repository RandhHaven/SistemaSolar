namespace EntitySistemaSolar
{
    #region Directives
    using EntitySistemaSolar.Interfaces;
    using System;
    #endregion

    #region Clase
    [Serializable]
    public class SistemaMeteorologicoBase
    {
        #region Properties
        public IPlaneta _IPlaneta { get; set; }

        public string Planeta { get; set; }

        public int PeriodoSequia { get; set; }

        public int PeriodoLluvia { get; set; }

        public int PeriodoPresionTemperatura { get; set; }

        public int Anios { get; set; }
        #endregion

        #region Constructor
        public SistemaMeteorologicoBase()
        {
            //_IPlaneta = new Planeta();
        }
        #endregion
    }
    #endregion
}
