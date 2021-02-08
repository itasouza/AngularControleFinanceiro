using DevIO.Business.Models;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Interfaces
{
    public interface IGanhosRepositorio : IRepositorioGenerico<Ganho>
    {
        IQueryable<Ganho> PegarGanhosPeloUsuarioId(string usuarioId);

        IQueryable<Ganho> FiltrarGanhos(string nomeCategoria);

        Task<double> PegarGanhoTotalPeloUsuarioId(string usuarioId);
    }
}
