
using DevIO.Business.Models;
using DevIO.Data.Context;
using DevIO.Data.Interfaces;
using System;
using System.Linq;

namespace DevIO.Data.Repository
{
    public class MesRepositorio : RepositorioGenerico<Mes>, IMesRepositorio
    {
        private readonly MeuDbContext _contexto;
        public MesRepositorio(MeuDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public new IQueryable<Mes> PegarTodos()
        {
            try
            {
                return _contexto.Meses.OrderBy(m => m.MesId);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
