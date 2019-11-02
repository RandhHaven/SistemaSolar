namespace EntitySistemaSolar
{
    #region Directives
    using EntitySistemaSolar.Interfaces;
    using EntitySistemaSolar.Planetas;
    #endregion

    #region Clase
    public class SistemaSolar : ISistemaSolar
    {
        #region Properties
        public IPlaneta _IPlanetaVulcano { get; set; }

        public IPlaneta _IPlanetaBetasoide { get; set; }

        public IPlaneta _IPlanetaFerengi { get; set; }
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
            return false;
        }

        public void ConstruirEcuacionRecta(int posicionx, int posiciony, int posicionx1, int posiciony2, IPlaneta unPlaneta)
        {

        }
        #endregion
    }
    #endregion
}
