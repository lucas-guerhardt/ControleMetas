﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMetas.Exceptions
{
    public class NotFoundException(string message) : Exception(message)
    /* Classe de exceção para erros de não encontrado*/
    {
    }
}
