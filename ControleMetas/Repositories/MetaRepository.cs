using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMetas.Exceptions;
using ControleMetas.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace ControleMetas.Repositories
{
    public class MetaRepository(AppDbContext context)
    /*Classe para manipular as metas no banco de dados*/
    {
        private readonly AppDbContext _context = context;

        public string Add(MetaModel meta)
        /* Método para adicionar uma nova meta no banco de dados
         * Recebe um objeto do tipo MetaModel
         * Retorna o id da meta adicionada
         */
        {
            _context.Add(meta);
            _context.SaveChanges();
            return meta.Id;
        }

        public List<MetaModel> ListAll()
        /* Método para listar todas as metas no banco de dados
         * Retorna uma lista de MetaModel
         */
        {
            return [.. _context.Metas];
        }

        public MetaModel? FindById(string id)
        /* Método para encontrar uma meta no banco de dados pelo id
         * Recebe o id da meta
         * Retorna um objeto do tipo MetaModel
         */
        {
            if (!_context.Metas.Any()) return null;

            return _context.Metas.FirstOrDefault(m => m.Id.Trim() == id.Trim());
        }

        public string? Update(string id, MetaModel meta)
        /* Método para atualizar uma meta no banco de dados
         * Recebe o id da meta e um objeto do tipo MetaModel
         * Retorna o id da meta atualizada
         */
        {
            var metaToUpdate = FindById(id);

            if (metaToUpdate == null) return null;
            
            if(meta.Nome != metaToUpdate.Nome)
                metaToUpdate.Nome = meta.Nome;

            if(meta.Formato != metaToUpdate.Formato)
                metaToUpdate.Formato = meta.Formato;

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
        /* Método para remover uma meta do banco de dados
         * Recebe o id da meta
         * Retorna o id da meta removida ou uma exceção caso a meta não seja encontrada
         */
        {
            var meta = FindById(id) ?? throw new NotFoundException($"A meta com id: {id} não foi encontrada");
            _context.Metas.Remove(meta);
            _context.SaveChanges();

            return meta.Id;
        }
    }
}
