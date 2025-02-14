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
    /* A classe Controller faz a comunicação entre a View e o Model.*/
    {
        private readonly VendedorRepository VendedorRepository = new();

        public List<VendedorModel> Get()
        /* Método responsável por listar todos os vendedores
         * Retorna uma lista de VendedorModel.
         */
        {
            return VendedorRepository.ListAll();
        }

        public VendedorModel? Get(string id)
        /* Método responsável por buscar um vendedor pelo Id
         * Recebe uma string id
         * Retorna um VendedorModel ou uma exceção caso o vendedor não seja encontrado.
         */
        {
            if (string.IsNullOrEmpty(id)) throw new NotFoundException($"O vendedor com Id { id } não foi encontrado.");

            return VendedorRepository.FindById(id);
        }

        public string Create(VendedorModel vendedor)
        /* Método responsável por criar um vendedor
         * Recebe um VendedorModel
         * Retorna o Id do vendedor criado ou uma exceção caso o vendedor seja nulo.
         */
        {
            if (vendedor == null) throw new BusinessException("O vendedor não pode ser nulo.");

            vendedor.Id = Guid.NewGuid().ToString();

            vendedor.Nome = FormatUtils.FormatarNome(vendedor.Nome);

            return VendedorRepository.Add(vendedor);
        }

        public string? Update(string id, VendedorModel vendedor)
        /* Método responsável por atualizar um vendedor
         * Recebe uma string id e um VendedorModel
         * Retorna o Id do vendedor atualizado ou uma exceção caso o vendedor seja nulo.
         */
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            if (vendedor == null) throw new BusinessException("O vendedor não pode ser nulo.");

            var vendedorAtualizado = VendedorRepository.Update(id, vendedor);

            return vendedorAtualizado ?? throw new NotFoundException($"O vendedor com Id {id} não foi encontrado.");
        }

        public string? Delete(string id)
        /* Método responsável por remover um vendedor
         * Recebe uma string id
         * Retorna o Id do vendedor removido ou uma exceção caso o vendedor não seja encontrado.
         */
        {
            if (string.IsNullOrEmpty(id)) throw new BusinessException("O Id não pode ser nulo ou vazio.");

            var vendedorRemovido = VendedorRepository.Remove(id);

            return vendedorRemovido ?? throw new NotFoundException($"O vendedor com Id {id} não foi encontrado.");
        }


    }
}
