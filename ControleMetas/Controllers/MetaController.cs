using System;
using System.Collections.Generic;
using System.Linq;
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
        private MetaRepository MetaRepository = new();

        public List<MetaModel> Get()
        {
            return MetaRepository.ListAll();
        }

        public MetaModel? Get(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            var meta = MetaRepository.FindById(id);

            return meta ?? throw new NotFoundException($"A meta com Id {id} não foi encontrada.");
        }

        public string Create(MetaModel meta)
        {
            if (meta == null) throw new BusinessException("A meta não pode ser nula.");

            meta.Id = Guid.NewGuid().ToString();

            meta.Nome = FormatUtils.FormatarNome(meta.Nome);

            return MetaRepository.Add(meta);
        }

        public string? Update(string id, MetaModel meta)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            if (meta == null) throw new BusinessException("A meta não pode ser nula.");

            var metaAtualizada = MetaRepository.Update(id, meta);

            return metaAtualizada ?? throw new NotFoundException($"A meta com Id {id} não foi encontrada.");
        }

        public string? Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            var metaRemovida = MetaRepository.Remove(id);

            return metaRemovida ?? throw new NotFoundException($"A meta com Id {id} não foi encontrada.");
        }
    }
}
