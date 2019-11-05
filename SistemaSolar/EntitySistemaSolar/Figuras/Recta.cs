using EntitySistemaSolar.Interfaces;

namespace EntitySistemaSolar.Figuras
{
    public class Recta : EcuacionFigura, IRecta
    {
        public int PuntoPaso { get; set; }
        public decimal Pendiente { get; set; }

        public decimal CoordenadaX { get; set; }

        public decimal CoordenadaY { get; set; }
        public Recta() => this.ConstruirEcuacionRecta();

        public Recta(decimal Pendiente, int puntoPaso, int coordenadax, int coordenaday)
        {
        }

        public void ConstruirEcuacionRecta()
        {
            CoordenadaY = Pendiente * CoordenadaX + PuntoPaso;
        }

        public bool ValidarSiEstaEnRecta()
        {
            return false;
        }
    }
}
