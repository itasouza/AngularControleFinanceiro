
using DevIO.Business.Models;
using DevIO.Data.Context;
using DevIO.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class CategoriaRepositorio : RepositorioGenerico<Categoria>, ICategoriaRepositorio
    {
        private readonly MeuDbContext _contexto;

        public CategoriaRepositorio(MeuDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public new IQueryable<Categoria> PegarTodos()
        {
            try
            {
                return _contexto.Categorias.Include(c => c.Tipo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public new async Task<Categoria> PegarPeloId(int id)
        {
            try
            {
                var entity = await _contexto.Categorias.Include(c => c.Tipo).FirstOrDefaultAsync(c => c.CategoriaId == id);
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable<Categoria> FiltrarCategorias(string nomeCategoria)
        {
            try
            {
                var entity = _contexto.Categorias.Include(c => c.Tipo).Where(c => c.Nome.Contains(nomeCategoria));
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable<Categoria> PegarCategoriasPeloTipo(string tipo)
        {
            try
            {
                return _contexto.Categorias.Include(c => c.Tipo).Where(c => c.Tipo.Nome == tipo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
