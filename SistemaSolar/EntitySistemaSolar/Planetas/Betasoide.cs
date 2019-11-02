namespace EntitySistemaSolar.Planetas
{    
    #region Directives
    using System;
    using EntitySistemaSolar.Enumerados;
    #endregion

    #region Clase 
    sealed class Betasoide : Planeta
    {
        public Betasoide()
        {            
        }

        public override void Initialize(int anios)
        {
            try
            {
                this.VelocidadAngular = 3;
                this.Radio = 2000;
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
