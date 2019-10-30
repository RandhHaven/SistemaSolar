namespace SistemaSolarBussinesCore
{
    using EntitySistemaSolar;
    using System;

    public class SistemaSolarBussinesCore
    {
        public SistemaSolar unSistemaSolar { get; set; }

        public SistemaSolarBussinesCore()
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
