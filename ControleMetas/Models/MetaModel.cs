using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Models.Enum;

namespace ControleMetas.Models
{
    [Table("Metas")]
    public class MetaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Vendedor { get; set; }

        [Required]
        public FormatoMetaEnum Formato { get; set; }

        [Required]
        public CategoriaMetaEnum Categoria { get; set; }

        [Required]
        public PeriodicidadeMetaEnum Periodicidade { get; set; }

        [Required]
        public decimal Valor { get; set; }

        public MetaModel()
        {
            Nome = string.Empty;
            Vendedor = string.Empty;
        }

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
