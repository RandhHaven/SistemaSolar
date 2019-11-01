#region Directives
using AServiceSistemaSolar.Interface;
using EntitySistemaSolar;
using System.Collections.Generic;
using WsSistemaSolar;
#endregion

namespace AServiceSistemaSolar
{
    public class SistemaSolarSA : AServiceAccess, ISistemaSolarSA
    {
        ServiceSistemaSolar ws = new ServiceSistemaSolar();

        public List<SistemaMeteorologicoBase> ObtenerSistemaMeteorologico(int anios)
        {
            result =  ws.GetData(anios);
            return (List<SistemaMeteorologicoBase>)Deserialize();
        }
    }
}
