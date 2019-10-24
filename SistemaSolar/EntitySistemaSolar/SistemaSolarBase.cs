namespace EntitySistemaSolar

{
    #region Directives
    using EntitySistemaSolar.Enumerados;
    using EntitySistemaSolar.Interfaces;
    #endregion
    internal abstract class SistemaSolarBase : ISistemaSolarBase
    {
        #region Properties
        public virtual int VelocidadAangular {get; set;}

        public virtual int Radio { get; set; }

        public virtual int Angulo { get; set; }

        //Antihorario = false; Horario = true
        public virtual EnumSentido.Sentido Sentido { get; set; }
        #endregion

        #region Methods
        public abstract void Initialize();
        #endregion
    }
}
