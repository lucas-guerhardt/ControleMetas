using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Exceptions;
using ControleMetas.Models;
using ControleMetas.Repositories;
using ControleMetas.Utils.FormatUtils;

namespace ControleMetas.Controllers
{
    public class MetaController
    /* A classe Controller faz a comunicação entre a View e o Model.*/
    {
        private readonly MetaRepository _metaRepository;

        private readonly HistoricoController _historicoController = HistoricoController.Instance;

        //Construtor Privado para Arquitetura Singleton
        private MetaController()
        {
            var dbContext = new AppDbContext();
            _metaRepository = new MetaRepository(dbContext);
        }

        private static MetaController? _instance;

        //A arquitetura Singleton garante que só haverá uma instância de MetaController
        public static MetaController Instance
        {
            get
            {
                _instance ??= new MetaController();
                return _instance;
            }
        }

        public List<MetaModel> Get()
        /* Método responsável por listar todas as metas
         * Retorna uma lista de MetaModel.
         */
        {
            _historicoController.Create(new HistoricoModel("Listar Metas", DateTime.Now, "As metas foram listadas"));
            return _metaRepository.ListAll();
        }

        public MetaModel? Get(string id)
        /* Método responsável por buscar uma meta pelo Id
         * Recebe uma string id
         * Retorna um MetaModel ou uma exceção caso a meta não seja encontrada.
         */
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            var meta = _metaRepository.FindById(id);

            if (meta == null)
            {
                _historicoController.Create(new HistoricoModel("Obter Meta por Id", DateTime.Now, $"A meta com Id {id} não foi encontrada."));
                throw new NotFoundException($"A meta com Id {id} não foi encontrada.");
            }

            _historicoController.Create(new HistoricoModel("Obter Meta por Id", DateTime.Now, $"A meta com Id {id} foi retornada."));
            return meta;
        }

        public string Create(MetaModel meta)
        /* Método responsável por criar uma nova meta
         * Recebe um MetaModel
         * Retorna o Id da meta criada ou uma exceção caso a meta recebida seja nula.
         */
        {
            if (meta == null) throw new BusinessException("A meta não pode ser nula.");

            meta.Nome = FormatUtils.FormatarNome(meta.Nome);
            meta.Valor /= 100;

            _historicoController.Create(new HistoricoModel("Criar Nova Meta", DateTime.Now, $"Uma nova meta de nome {meta.Nome} foi criada."));
            return _metaRepository.Add(meta);
        }

        public string? Update(string id, MetaModel meta)
        /* Método responsável por atualizar uma meta
         * Recebe uma string id e um MetaModel
         * Retorna o Id da meta atualizada ou uma exceção caso a meta recebida seja nula.
         */
        {
            if (string.IsNullOrEmpty(id))
            {
                _historicoController.Create(new HistoricoModel("Atualizar Meta", DateTime.Now, $"A meta não pode ser atualizada pois o Id era nulo ou vazio."));
                throw new BusinessException("O Id não pode ser nulo ou vazio.");
            }

            if (meta == null)
            {
                _historicoController.Create(new HistoricoModel("Atualizar Meta", DateTime.Now, $"A meta não pode ser atualizada pois a meta era nula."));
                throw new BusinessException("A meta não pode ser nula.");
            }

            var metaAtualizada = _metaRepository.Update(id, meta);

            if (metaAtualizada == null)
            {
                _historicoController.Create(new HistoricoModel("Atualizar Meta", DateTime.Now, $"A meta com Id {id} não foi encontrada."));
                throw new NotFoundException($"A meta com Id {id} não foi encontrada.");
            }

            _historicoController.Create(new HistoricoModel("Atualizar Meta", DateTime.Now, $"A meta com Id {id} foi atualizada."));
            return metaAtualizada;
        }

        public string? Delete(string id)
        /* Método responsável por remover uma meta
         * Recebe uma string id
         * Retorna o Id da meta removida ou uma exceção caso a meta não seja encontrada.
         */
        {
            if (string.IsNullOrEmpty(id))
            {
                _historicoController.Create(new HistoricoModel("Remover Meta", DateTime.Now, $"A meta não pode ser removida pois o Id era nulo ou vazio."));
                throw new BusinessException("O Id não pode ser nulo ou vazio.");
            }

            var metaRemovida = _metaRepository.Remove(id);

            if (metaRemovida == null)
            {
                _historicoController.Create(new HistoricoModel("Remover Meta", DateTime.Now, $"A meta com Id {id} não foi encontrada."));
                throw new NotFoundException($"A meta com Id {id} não foi encontrada.");
            }

            _historicoController.Create(new HistoricoModel("Remover Meta", DateTime.Now, $"A meta com Id {id} foi removida."));
            return metaRemovida;
        }
    }
}
