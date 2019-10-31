namespace EntitySistemaSolar.Planetas
{    
    #region Directives
    using System;
    using EntitySistemaSolar.Enumerados;
    #endregion

    #region Clase 
    class Betasoide : Planeta
    {
        public Betasoide()
        {
        }

        public override void Initialize()
        {
            try
            {
                this.VelocidadAangular = 3;
                this.Radio = 2000;
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
