namespace EntitySistemaSolar.Planetas
{   
    #region Directives
    using System;
    using EntitySistemaSolar.Enumerados;
    #endregion

    #region Class
    sealed class Ferengi : Planeta
    {
        public override void Initialize(int anios)
        {
            try
            {
                this.VelocidadAngular = 1;
                this.Radio = 500;
                this.Sentido = EnumSentido.Sentido.Horario;
                this.CoordenadaX = 0;
                this.CoordenadaY = 0;
                this.CantidadDias = (anios * (360 / this.VelocidadAngular));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    #endregion
}
