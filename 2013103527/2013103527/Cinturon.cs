﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013103527
{
    public class Cinturon
    {
        public string NumSerie { get; set; }
        public int Metraje { get; set; }
        
        public Cinturon ()
	    {
                
	    }

        public Cinturon(string _NumSerie,int _Metraje)
        {
            NumSerie = _NumSerie;
            Metraje = _Metraje;
        }
    }
}
