using EntitySistemaSolar.Enumerados;

namespace EntitySistemaSolar.Interfaces
{
    public interface IPlaneta
    {
        #region Properties
        int VelocidadAngular { get; set; }

        int Radio { get; set; }

        int Angulo { get; set; }

        //Antihorario = false; Horario = true
        EnumSentido.Sentido Sentido { get; set; }

        int CoordenadaX { get; set; }

        int CoordenadaY { get; set; }

        int CantidadDias { get; set; }
        #endregion

        #region Methods
        void Initialize(int anios);
        #endregion
    }
}
