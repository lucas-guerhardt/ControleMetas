using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Models;

namespace ControleMetas.Repositories
{
    public class VendedorRepository
    /*Classe para manipular os dados dos vendedores, não está vinculada com o banco de dados*/
    {
        private static readonly List<VendedorModel> _vendedores = [];

        public string Add(VendedorModel vendedor)
        /*Metodo para adicionar um vendedor*/
        {
            _vendedores.Add(vendedor);
            return vendedor.Id;
        }

        public List<VendedorModel> ListAll()
        /*Metodo para listar todos os vendedores*/
        {
            return _vendedores;
        }

        public VendedorModel? FindById(string id)
        /*Metodo para encontrar um vendedor pelo id*/
        {
            if (_vendedores.Count == 0) return null;
            return _vendedores.FirstOrDefault(v => v.Id == id);
        }

        public string? Update(string id, VendedorModel vendedor)
        /*Metodo para atualizar um vendedor*/
        {
            var vendedorToUpdate = FindById(id);
            if (vendedorToUpdate == null) return null;
            if (vendedor.Nome != vendedorToUpdate.Nome)
                vendedorToUpdate.Nome = vendedor.Nome;
            return vendedorToUpdate.Id;
        }

        public string? Remove(string id)
        /*Metodo para remover um vendedor*/
        {
            var vendedor = FindById(id);
            if (vendedor == null) return null;
            _vendedores.Remove(vendedor);
            return vendedor.Id;
        }
    }
}
