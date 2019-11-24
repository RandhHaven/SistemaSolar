namespace EntitySistemaSolar.Planetas
{
    #region Directives
    using EntitySistemaSolar.Enumerados;
    using System;
    using System.Collections;
    #endregion

    #region Clase
    sealed class Vulcano : Planeta
    {
        #region Constructor
        public Vulcano() : base()
        {

        }
        #endregion

        #region Methods
        public override void Initialize(int anios)
        {
            try
            {
                this.VelocidadAngular = 5;
                this.Radio = 1000;
                this.Sentido = EnumSentido.Sentido.Antihorario;
                this.CoordenadaX = 0;
                this.CoordenadaY = 0;
                this.CantidadDias = (anios * (360 / this.VelocidadAngular));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        #endregion
    }
    #endregion
}
