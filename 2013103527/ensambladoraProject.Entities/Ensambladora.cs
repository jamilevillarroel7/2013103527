using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
    public class Ensambladora
    {

        List<Carro> _Carros;
        Volante volante;
        Parabrisas parabrisas;
        Propietario propietario;
        TipoAuto tipoauto;

        public Ensambladora()
        {
            _Carros = new List<Carro>();
            volante = new Volante();
            propietario = new Propietario();
            parabrisas = new Parabrisas();
            tipoauto = new TipoAuto();
        }

        public void Agregar(Carro carro)
        {
            if (_Carros.Count == 6)
                return;
                          
        
                  
        }
    }
}
