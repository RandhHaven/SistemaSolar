namespace SistemaSolar.Models
{
    #region Directives
    using AServiceSistemaSolar.Interface;
    #endregion

    #region Clase
    public class SistemaMeteorologico
    {
        #region Properties
    
        public string PeriodoSequia { get; set; }

        public string PeriodoLluvia { get; set; }

        public string PeriodoPresionTemperatura { get; set; }

        public int Anios { get; set; }
        #endregion

        #region Constructor
        public SistemaMeteorologico(int Anios = 0)
        {
            this.Anios = Anios;
        }
        #endregion

        #region Methods
        public void ObtenerResultado(int anios)
        {
            
        }
        #endregion
    }
    #endregion
}
