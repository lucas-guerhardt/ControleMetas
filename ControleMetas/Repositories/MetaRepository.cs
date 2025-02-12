using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Models;

namespace ControleMetas.Repositories
{
    public class MetaRepository
    {
        private static List<MetaModel> _metas = [];

        public string Add(MetaModel meta)
        {
            _metas.Add(meta);
            return meta.Id;
        }

        public List<MetaModel> ListAll()
        {
            return _metas;
        }

        public MetaModel? FindById(string id)
        {
            if (_metas.Count == 0) return null;

            return _metas.FirstOrDefault(m => m.Id == id);
        }

        public string? Update(string id, MetaModel meta)
        {
            var metaToUpdate = FindById(id);

            if (metaToUpdate == null) return null;
            
            if(meta.Nome != metaToUpdate.Nome)
                metaToUpdate.Nome = meta.Nome;

            if (meta.Vendedor != metaToUpdate.Vendedor)
                metaToUpdate.Vendedor = meta.Vendedor;

            if (meta.Valor != metaToUpdate.Valor)
                metaToUpdate.Valor = meta.Valor;

            if (meta.Periodicidade != metaToUpdate.Periodicidade)
                metaToUpdate.Formato = meta.Formato;

            if (meta.Categoria != metaToUpdate.Categoria)
                metaToUpdate.Categoria = meta.Categoria;

            return metaToUpdate.Id;
        }

        public string? Remove(string id)
        {
            var meta = FindById(id);
            if (meta == null) return null;
            
            _metas.Remove(meta);
            return meta.Id;
        }
    }
}
