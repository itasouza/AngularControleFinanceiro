

using DevIO.Business.Models;
using DevIO.Data.Context;
using DevIO.Data.Interfaces;

namespace DevIO.Data.Repository
{
    public class TipoRepositorio : RepositorioGenerico<Tipo>, ITipoRepositorio
    {
        public TipoRepositorio(MeuDbContext contexto) : base(contexto)
        {
        }
    }
}
