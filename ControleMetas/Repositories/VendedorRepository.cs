using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Models;

namespace ControleMetas.Repositories
{
    public class VendedorRepository
    {
        private List<VendedorModel> _vendedores = new List<VendedorModel>();

        public string Add(VendedorModel vendedor)
        {
            _vendedores.Add(vendedor);
            return vendedor.Id;
        }

        public List<VendedorModel> ListAll()
        {
            return _vendedores;
        }

        public VendedorModel? FindById(string id)
        {
            if (_vendedores.Count == 0) return null;
            return _vendedores.FirstOrDefault(v => v.Id == id);
        }

        public string? Update(string id, VendedorModel vendedor)
        {
            var vendedorToUpdate = FindById(id);
            if (vendedorToUpdate == null) return null;
            if (vendedor.Nome != vendedorToUpdate.Nome)
                vendedorToUpdate.Nome = vendedor.Nome;
            return vendedorToUpdate.Id;
        }

        public string? Remove(string id)
        {
            var vendedor = FindById(id);
            if (vendedor == null) return null;
            _vendedores.Remove(vendedor);
            return vendedor.Id;
        }
    }
}
