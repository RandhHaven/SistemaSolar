namespace EntitySistemaSolar
{   
    #region Directives
    using EntitySistemaSolar.Interfaces;
    using EntitySistemaSolar.Planetas;
    using System.Collections.Generic;
    using System;
    using EntitySistemaSolar.Figuras;
    #endregion

    #region Clase
    public class SistemaSolar : ISistemaSolar
    {
        #region Properties
        public IPlaneta _IPlanetaVulcano { get; set; }

        public IPlaneta _IPlanetaBetasoide { get; set; }

        public IPlaneta _IPlanetaFerengi { get; set; }

        public IRecta _IRecta { get; set; }
        #endregion

        #region Constructor
        public SistemaSolar()
        {
            _IPlanetaVulcano = new Vulcano();
            _IPlanetaBetasoide = new Betasoide();
            _IPlanetaFerengi = new Ferengi();
            
        }
        #endregion

        #region Methods
        public void Initialize(int anios)
        {
            _IPlanetaBetasoide.Initialize(anios);
            _IPlanetaVulcano.Initialize(anios);
            _IPlanetaFerengi.Initialize(anios);
        }

        public bool IsTriangule(IPlaneta unPlanetaVulcano, IPlaneta unPlanetaBetasoide, IPlaneta unPlanetaFerengi)
        {

            return false;
        }

        public bool IsRecta(Planeta unPlaneta)
        {
            try
            {
                _IRecta = new Recta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public void ConstruirEcuacionRecta(int posicionx, int posiciony, int posicionx1, int posiciony2, IPlaneta unPlaneta)
        {

        }

        /// <summary>
        /// Recorro la cantidad de dias de cada planeta y por cada dia voy verificando si entre los 3 planetas forman una recta
        /// en caso contrario si no forman una recta, forman un triangulo.
        /// </summary>
        /// <returns></returns>
        public List<SistemaMeteorologicoBase> CargarSistemaMeteorologico()
        {
            for (int iDias = 0; iDias < _IPlanetaBetasoide.CantidadDias; iDias++)
            {
                for (int jDias = 0; jDias < _IPlanetaVulcano.CantidadDias; jDias++)
                {
                    for (int kDias = 0; kDias < _IPlanetaFerengi.CantidadDias; kDias++)
                    {
                        _IPlanetaFerengi.CalcularCoordenadas(kDias);
                    }
                }
            }
            return new List<SistemaMeteorologicoBase>();
        }

        #endregion
    }
    #endregion
}
