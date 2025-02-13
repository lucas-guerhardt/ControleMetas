using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Models;

namespace ControleMetas.Repositories
{
    public class MetaRepository(AppDbContext context)
    {
        private readonly AppDbContext _context = context;

        public string Add(MetaModel meta)
        {
            _context.Add(meta);
            _context.SaveChanges();
            return meta.Id;
        }

        public List<MetaModel> ListAll()
        {
            return _context.Metas.ToList();
        }

        public MetaModel? FindById(string id)
        {
            if (_context.Metas.Any()) return null;

            return _context.Metas.FirstOrDefault(m => m.Id == id); ;
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

            _context.SaveChanges();

            return metaToUpdate.Id;
        }

        public string? Remove(string id)
        {
            var meta = FindById(id);
            if (meta == null) return null;

            _context.Metas.Remove(meta);
            _context.SaveChanges();

            return meta.Id;
        }
    }
}
