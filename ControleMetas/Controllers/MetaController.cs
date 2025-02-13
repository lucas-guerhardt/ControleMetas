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
    {
        private readonly MetaRepository _metaRepository;

        //Construtor Privado para Arquitetura Singleton
        private MetaController() 
        {
            Debug.WriteLine("Instância de MetaController criada.");
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

        //Métodos de CRUD

        //Método para listar todas as metas
        public List<MetaModel> Get()
        {
            return _metaRepository.ListAll();
        }


        //Método para buscar uma meta pelo Id
        public MetaModel? Get(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            var meta = _metaRepository.FindById(id);

            return meta ?? throw new NotFoundException($"A meta com Id {id} não foi encontrada.");
        }


        //Método para criar uma nova meta
        public string Create(MetaModel meta)
        {
            if (meta == null) throw new BusinessException("A meta não pode ser nula.");

            meta.Nome = FormatUtils.FormatarNome(meta.Nome);

            return _metaRepository.Add(meta);
        }


        //Método para atualizar uma meta
        public string? Update(string id, MetaModel meta)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            if (meta == null) throw new BusinessException("A meta não pode ser nula.");

            var metaAtualizada = _metaRepository.Update(id, meta);

            return metaAtualizada ?? throw new NotFoundException($"A meta com Id {id} não foi encontrada.");
        }


        //Método para deletar uma meta
        public string? Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            var metaRemovida = _metaRepository.Remove(id);

            return metaRemovida ?? throw new NotFoundException($"A meta com Id {id} não foi encontrada.");
        }
    }
}
