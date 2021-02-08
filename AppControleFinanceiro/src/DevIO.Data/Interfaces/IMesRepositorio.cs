using DevIO.Business.Models;
using System.Linq;

namespace DevIO.Data.Interfaces
{
    public interface IMesRepositorio : IRepositorioGenerico<Mes>
    {
        new IQueryable<Mes> PegarTodos();
    }
}
