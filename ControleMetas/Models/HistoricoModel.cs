using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMetas.Models
{
    [Table("Historico")]
    public class HistoricoModel
    /*Classe para representar o histórico de metas*/
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public DateTime Data { get; set; } = DateTime.Now;

        [Required]
        public string Acao { get; set; } = string.Empty;

        public string Detalhes { get; set; } = string.Empty;

        public HistoricoModel(string acao, DateTime data, string detalhes)
        {
            Acao = acao;
            Data = data;
            Detalhes = detalhes;
        }
    }
}
