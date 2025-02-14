using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Models;

namespace ControleMetas.Repositories
{
    public class HistoricoRepository
    /*Classe para manipulação de dados do histórico de metas*/
    {
        private readonly AppDbContext _context;

        public HistoricoRepository(AppDbContext context)
        {
            _context = context;
        }

        public string Add(HistoricoModel historico)
        /* Método para adicionar um novo histórico no banco de dados
         * Recebe um objeto do tipo HistoricoModel
         * Retorna o id do histórico adicionado
         */
        {
            _context.Historico.Add(historico);
            _context.SaveChanges();
            return historico.Id;
        }

        public List<HistoricoModel> ListAll()
        /* Método para listar todos os históricos no banco de dados
         * Retorna uma lista de HistoricoModel
         */
        {
            return [.. _context.Historico];
        }
    }
}
