namespace EntitySistemaSolar
{
    #region Directives
    using EntitySistemaSolar.Enumerados;
    using EntitySistemaSolar.Interfaces;
    using System.Collections.Generic;
    #endregion

    #region Clase
    public class SistemaSolar : ISistemaSolar
    {
        #region Properties
        public List<SistemaMeteorologicoBase> ListaSistemaMeteorologico { get; set; }
       

        #endregion

        #region Methods
        public void Initialize()
        {
        }
        #endregion
    }
    #endregion
}
