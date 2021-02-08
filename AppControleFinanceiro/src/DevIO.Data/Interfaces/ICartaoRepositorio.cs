using DevIO.Business.Models;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Interfaces
{
    public interface ICartaoRepositorio : IRepositorioGenerico<Cartao>
    {
        IQueryable<Cartao> PegarCartoesPeloUsuarioId(string usuarioId);

        IQueryable<Cartao> FiltrarCartoes(string numeroCartao);

        Task<int> PegarQuantidadeCartoesPeloUsuarioId(string usuarioId);
    }
}
