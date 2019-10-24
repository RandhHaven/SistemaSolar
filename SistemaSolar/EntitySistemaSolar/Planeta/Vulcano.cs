namespace EntitySistemaSolar.Planeta
{
    #region Directives
    using EntitySistemaSolar.Enumerados;
    using System;
    #endregion

    #region Clase
    class Vulcano : SistemaSolarBase
    {
        public override void Initialize()
        {
            try
            {
                this.VelocidadAangular = 5;
                this.Radio = 1000;
                this.Sentido = EnumSentido.Sentido.Antihorario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    #endregion
}
