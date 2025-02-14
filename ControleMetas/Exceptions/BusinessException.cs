using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMetas.Exceptions
{
    public class BusinessException(string message) : Exception(message)
    /* Classe de exceção para erros de negócio */
    {
    }
}
