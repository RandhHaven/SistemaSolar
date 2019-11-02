namespace EntitySistemaSolar
{
    using EntitySistemaSolar.Enumerados;
    using System;
    using System.Collections;
    using EntitySistemaSolar.Interfaces;

    public abstract class Planeta: IPlaneta
    {
        #region Properties
        public virtual int VelocidadAngular { get; set; }

        public virtual int Radio { get; set; }

        public virtual int Angulo { get; set; }

        //Antihorario = false; Horario = true
        public virtual EnumSentido.Sentido Sentido { get; set; }

        public virtual int CoordenadaX { get; set; }

        public virtual int CoordenadaY { get; set; }

        public virtual int CantidadDias { get; set; }
        #endregion

        #region Methods
        public abstract void Initialize(int anios);

        public virtual ArrayList GetPosicion()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new ArrayList();
        }

        public virtual ArrayList GetPosicionDia(int tiempo)
        {
            return new ArrayList();
        }
       
        #endregion
    }
}
