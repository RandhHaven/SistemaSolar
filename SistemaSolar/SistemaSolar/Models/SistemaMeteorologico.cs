namespace SistemaSolar.Models
{
    #region Directives
    using AServiceSistemaSolar.Interface;
    #endregion

    #region Clase
    public class SistemaMeteorologico
    {
        #region Properties
        ISistemaSolarSA _ISistemaSolarSA { get; set; }
        #endregion
        public string PeriodoSequia { get; set; }

        public string PeriodoLluvia { get; set; }

        public string PeriodoPresionTemperatura { get; set; }

        public void ObtenerResultado()
        {

        }
    }
    #endregion
}
