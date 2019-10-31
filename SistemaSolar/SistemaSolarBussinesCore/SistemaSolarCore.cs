namespace SistemaSolarBussinesCore
{
    using EntitySistemaSolar;
    using EntitySistemaSolar.Interfaces;
    using System;
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


    }
}
