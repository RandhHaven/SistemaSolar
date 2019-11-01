namespace SistemaSolar.Models
{
    #region Directives
    using AServiceSistemaSolar.Interface;
    #endregion

    #region Clase
    public class SistemaMeteorologico
    {
        #region Properties
    
        public int PeriodoSequia { get; set; }

        public int PeriodoLluvia { get; set; }

        public int PeriodoPresionTemperatura { get; set; }

        public int Anios { get; set; }

        public string NombrePlaneta { get; set; }
        #endregion

        #region Constructor
        public SistemaMeteorologico(int Anios = 0)
        {
            this.Anios = Anios;
        }
        #endregion
    }
    #endregion
}
