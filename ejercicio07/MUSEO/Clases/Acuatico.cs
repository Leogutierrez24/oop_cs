﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO
{
    public class Acuatico : Animal
    {
        public Acuatico(string nombre, TipoAlimentacion tipoAlimentacion, long periodo) : base(nombre, tipoAlimentacion, periodo)
        {
        }
    }
}
