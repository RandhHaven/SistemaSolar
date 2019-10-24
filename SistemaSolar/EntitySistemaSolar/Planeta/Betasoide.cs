namespace EntitySistemaSolar.Planeta
{    
    #region Directives
    using System;
    using EntitySistemaSolar.Enumerados;
    #endregion

    #region Clase 
    class Betasoide : SistemaSolarBase
    {
        public override void Initialize()
        {
            try
            {
                this.VelocidadAangular = 3;
                this.Radio = 2000;
                this.Sentido = EnumSentido.Sentido.Horario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    #endregion
}
