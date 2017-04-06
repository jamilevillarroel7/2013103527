using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013103527
{
    public class Propietario
    {
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos {get; set;}
        public string LicenciaConducir{get; set;}
       
        public Propietario()
	    {
                
	    }

        public Propietario(string _DNI,string _Nombres, string _Apellidos,string _LicenciaConducir)
        {
            DNI = _DNI;
            Nombres = _Nombres;
            Apellidos = _Apellidos;
            LicenciaConducir = _LicenciaConducir;
        }
    }
}
