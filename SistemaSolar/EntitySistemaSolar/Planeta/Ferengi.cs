namespace EntitySistemaSolar.Planeta
{   
    #region Directives
    using System;
    using EntitySistemaSolar.Enumerados;
    #endregion

    sealed class Ferengi : SistemaSolarBase
    {
        public override void Initialize()
        {
            try
            {
                this.VelocidadAangular = 1;
                this.Radio = 500;
                this.Sentido = EnumSentido.Sentido.Horario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
