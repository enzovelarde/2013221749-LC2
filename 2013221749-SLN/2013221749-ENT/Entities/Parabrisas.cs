﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013221749_ENT.Entities
{
    public class Parabrisas
    {
        public int ParabrisasId { get; set; }
        public string NumSerie { get; set; }



        public Carro Carro { get; set; }

        public Parabrisas()
        {

        }
    }
       
}
