using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Models.Enum;

namespace ControleMetas.Models
{
    public class MetaModel
    {
        public string Id { get; set; } = string.Empty;

        public string Nome { get; set; } = string.Empty;

        public string Vendedor { get; set; } = string.Empty;

        public FormatoMetaEnum Formato { get; set; }

        public CategoriaMetaEnum Categoria { get; set; }

        public PeriodicidadeMetaEnum Periodicidade { get; set; }

        public decimal Valor { get; set; }

        public MetaModel() { }

        public MetaModel(string nome, string vendedor, FormatoMetaEnum formato, CategoriaMetaEnum categoria, PeriodicidadeMetaEnum periodicidade, decimal valor)
        {
            Vendedor = vendedor;
            Nome = nome;
            Formato = formato;
            Categoria = categoria;
            Periodicidade = periodicidade;
            Valor = valor;
        }
    }
}
