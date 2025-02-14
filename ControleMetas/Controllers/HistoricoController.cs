using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Repositories;
using ControleMetas.Models;

namespace ControleMetas.Controllers
{
    public class HistoricoController
    /* A classe Controller faz a comunicação entre a View e o Model.*/
    {
        private readonly HistoricoRepository _historicoRepository;

        //Construtor Privado para Arquitetura Singleton
        private HistoricoController()
        {
            var dbContext = new AppDbContext();
            _historicoRepository = new HistoricoRepository(dbContext);
        }

        private static HistoricoController? _instance;

        //A arquitetura Singleton garante que só haverá uma instância de MetaController
        public static HistoricoController Instance
        {
            get
            {
                _instance ??= new HistoricoController();
                return _instance;
            }
        }

        public List<HistoricoModel> Get()
        /* Método responsável por listar todas os históricos
         * Retorna uma lista de HistoricoModel.
         */
        {
            return _historicoRepository.ListAll();
        }

        public string Create(HistoricoModel historico)
        /* Método responsável por criar um novo histórico
         * Recebe um objeto do tipo HistoricoModel
         * Retorna o id do histórico criado.
         */
        {
            return _historicoRepository.Add(historico);
        }

    }
}
