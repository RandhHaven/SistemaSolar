using AServiceSistemaSolar.Interface;
using System;
using WsSistemaSolar;

namespace AServiceSistemaSolar
{
    public class SistemaSolarSA : ISistemaSolarSA
    {
        ServiceSistemaSolar ws = new ServiceSistemaSolar();

        public string ObtenerPeriodosSequia()
        {            
            int valor = 2;

            return ws.GetData(valor); 
        }
    }
}
