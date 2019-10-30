namespace EntitySistemaSolar.Planetas
{
    #region Directives
    using EntitySistemaSolar.Enumerados;
    using System;
    #endregion

    #region Clase
    class Vulcano : Planeta
    {
        public override void Initialize()
        {
            try
            {
                this.VelocidadAangular = 5;
                this.Radio = 1000;
                this.Sentido = EnumSentido.Sentido.Antihorario;
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
