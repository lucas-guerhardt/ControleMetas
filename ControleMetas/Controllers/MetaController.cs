using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Exceptions;
using ControleMetas.Models;
using ControleMetas.Repositories;

namespace ControleMetas.Controllers
{
    public class MetaController
    {
        private MetaRepository MetaRepository = new MetaRepository();

        public List<MetaModel> Get()
        {
            return MetaRepository.ListAll();
        }

        public MetaModel? Get(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            var meta = MetaRepository.FindById(id);

            if (meta == null) throw new NotFoundException($"A meta com Id {id} não foi encontrada.");

            return meta;
        }

        public string Create(MetaModel meta)
        {
            if (meta == null) throw new BusinessException("A meta não pode ser nula.");

            meta.Id = Guid.NewGuid().ToString();

            return MetaRepository.Add(meta);
        }

        public string? Update(string id, MetaModel meta)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            if (meta == null) throw new BusinessException("A meta não pode ser nula.");

            var metaAtualizada = MetaRepository.Update(id, meta);

            if (metaAtualizada == null) throw new NotFoundException($"A meta com Id {id} não foi encontrada.");

            return metaAtualizada;
        }

        public string? Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            var metaRemovida = MetaRepository.Remove(id);

            if (metaRemovida == null) throw new NotFoundException($"A meta com Id {id} não foi encontrada.");

            return metaRemovida;
        }
    }
}
