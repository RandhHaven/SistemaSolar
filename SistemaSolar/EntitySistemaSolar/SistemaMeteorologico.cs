namespace EntitySistemaSolar
{
    #region Directives
    using EntitySistemaSolar.Interfaces;
    using EntitySistemaSolar.Planetas;
    #endregion

    #region Clase
    public class SistemaMeteorologico
    {
        #region Properties
        public IPlaneta _IPlaneta { get; set; }
        #endregion

        #region Constructor
        public SistemaMeteorologico()
        {
            //_IPlaneta = new Planeta();
        }
        #endregion
    }
    #endregion
}
