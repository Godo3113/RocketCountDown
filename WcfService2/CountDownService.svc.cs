using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CountDownService" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CountDownService.svc o CountDownService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CountDownService : ICountDownService
    {
        public int Count(int start)  
        {
            return start--;
        }
    }
}
