using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Exceptions;
using ControleMetas.Models;
using ControleMetas.Repositories;
using ControleMetas.Utils.FormatUtils;

namespace ControleMetas.Controllers
{
    public class VendedorController
    {
        private VendedorRepository VendedorRepository = new();

        public List<VendedorModel> Get()
        {
            return VendedorRepository.ListAll();
        }

        public VendedorModel? Get(string id)
        {
            if(string.IsNullOrEmpty(id)) throw new NotFoundException($"O vendedor com Id { id } não foi encontrado.");

            return VendedorRepository.FindById(id);
        }

        public string Create(VendedorModel vendedor)
        {
            if (vendedor == null) throw new BusinessException("O vendedor não pode ser nulo.");

            vendedor.Id = Guid.NewGuid().ToString();

            vendedor.Nome = FormatUtils.FormatarNome(vendedor.Nome);

            return VendedorRepository.Add(vendedor);
        }

        public string? Update(string id, VendedorModel vendedor)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            if (vendedor == null) throw new BusinessException("O vendedor não pode ser nulo.");

            var vendedorAtualizado = VendedorRepository.Update(id, vendedor);

            return vendedorAtualizado ?? throw new NotFoundException($"O vendedor com Id {id} não foi encontrado.");
        }

        public string? Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            var vendedorRemovido = VendedorRepository.Remove(id);

            return vendedorRemovido ?? throw new NotFoundException($"O vendedor com Id {id} não foi encontrado.");
        }


    }
}
