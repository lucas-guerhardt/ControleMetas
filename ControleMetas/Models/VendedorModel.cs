using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMetas.Models
{
    public class VendedorModel
    {
        public string Id { get; set; } = string.Empty;

        public string Nome { get; set; } = string.Empty;

        public VendedorModel() { }

        public VendedorModel(string nome)
        {
            Nome = nome;
        }
    }
}
