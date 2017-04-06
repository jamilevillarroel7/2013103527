using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013103527
{
    public class Asiento
    {
      Cinturon _Cinturon;

        public string NumSerie { get; set; }
        
        public Asiento ()
	    {
                
	    }

        public Asiento(string _NumSerie)
        {
            _Cinturon = new Cinturon();
            NumSerie = _NumSerie;
            
        }

        }
    }

