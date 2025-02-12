using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Controllers;
using ControleMetas.Models;

namespace ControleMetas.Utils.Data
{
    public static class Data
    {
        public static void GerarVendedores()
        {
            VendedorController VendedorController = new();

            List<string> nomes =
            [
                "João Silva",
                "Maria Oliveira",
                "Carlos Souza",
                "Ana Santos",
                "Pedro Lima"
            ];

            foreach (var nome in nomes)
            {
                VendedorModel vendedor = new()
                {
                    Nome = nome
                };

                VendedorController.Create(vendedor);
            }
        }
    }
}
