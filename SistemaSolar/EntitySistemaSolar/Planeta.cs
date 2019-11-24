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

        public void GetPosition(int dias, ref int coordx, ref int coordy)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        public void CalcularCoordenadas(int dias)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
