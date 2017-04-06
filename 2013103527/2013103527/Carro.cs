using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013103527
{
    abstract class Carro
    {
        Parabrisas _Parabrisas;
        Volante _Volante;
        Llanta _Llanta;
        Asiento _Asiento;
        

        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
        
        public Carro ()
	    {
                
	    }

        public Carro(string _NumSerieMotor, string _NumSerieChasis)
        {
            _Parabrisas = new Parabrisas();
            _Volante = new Volante();
            _Llanta = new Llanta();
            _Asiento = new Asiento();
            NumSerieMotor = _NumSerieMotor;
            NumSerieChasis = _NumSerieChasis;
        }

    }
}

