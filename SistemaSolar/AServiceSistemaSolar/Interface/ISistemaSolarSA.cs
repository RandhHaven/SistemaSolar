namespace AServiceSistemaSolar.Interface
{    
    #region Directives
    using System.Collections.Generic;
    using EntitySistemaSolar;
    #endregion

    #region Interface
    public interface ISistemaSolarSA
    {
        List<SistemaMeteorologicoBase> ObtenerSistemaMeteorologico(int anios);
    }
    #endregion
}
