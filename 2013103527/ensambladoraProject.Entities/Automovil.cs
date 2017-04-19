using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
    public class Automovil
    {
        TipoAuto TipoAuto;
        Volante _volante;
        Parabrisas _parabrisas;
        Propietario _propietario;
        int numAsiento;
       public  Automovil(Volante volante, Parabrisas parabrisas, int numAsientos, Propietario propietario, TipoAuto tipoAuto) {
            TipoAuto= tipoAuto;
           
        }
    }
}
