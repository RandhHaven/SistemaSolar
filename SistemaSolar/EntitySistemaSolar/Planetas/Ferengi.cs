namespace EntitySistemaSolar.Planetas
{   
    #region Directives
    using System;
    using EntitySistemaSolar.Enumerados;
    #endregion

    #region Class
    sealed class Ferengi : Planeta
    {
        public override void Initialize()
        {
            try
            {
                this.VelocidadAangular = 1;
                this.Radio = 500;
                this.Sentido = EnumSentido.Sentido.Horario;
                this.CoordenadaX = 0;
                this.CoordenadaY = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    #endregion
}
