namespace SistemaSolarBussinesCore
{
    #region Directives
    using EntitySistemaSolar;
    using EntitySistemaSolar.Interfaces;
    using System;
    using System.Collections.Generic;
    #endregion

    #region Class
    public class SistemaSolarCore
    {
        public ISistemaSolar unSistemaSolar { get; set; }

        public SistemaSolarCore()
        {
            try
            {
                if(Object.Equals(unSistemaSolar, null))
                {
                    unSistemaSolar = new SistemaSolar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SistemaSolarCore> GetSistemaSolar()
        {
            return new List<SistemaSolarCore>();
        }
    }
    #endregion
}
