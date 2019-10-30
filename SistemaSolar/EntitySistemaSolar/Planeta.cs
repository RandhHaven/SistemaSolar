using EntitySistemaSolar.Enumerados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySistemaSolar
{
    public abstract class Planeta
    {
        #region Properties
        public virtual int VelocidadAangular { get; set; }

        public virtual int Radio { get; set; }

        public virtual int Angulo { get; set; }

        //Antihorario = false; Horario = true
        public virtual EnumSentido.Sentido Sentido { get; set; }

        public virtual int CoordenadaX { get; set; }

        public virtual int CoordenadaY { get; set; }
        #endregion

        #region Methods
        public abstract void Initialize();

        public virtual ArrayList GetPosicion()
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
            return new ArrayList();
        }
        #endregion
    }
}
