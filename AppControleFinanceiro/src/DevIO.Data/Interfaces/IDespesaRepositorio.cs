using DevIO.Business.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Interfaces
{
    public interface IDespesaRepositorio : IRepositorioGenerico<Despesa>
    {
        IQueryable<Despesa> PegarDespesasPeloUsuarioId(string usuarioId);

        void ExcluirDespesas(IEnumerable<Despesa> despesas);

        Task<IEnumerable<Despesa>> PegarDespesasPeloCartaoId(int cartaoId);

        IQueryable<Despesa> FiltrarDespesas(string nomeCategoria);

        Task<double> PegarDespesaTotalPorUsuarioId(string usuarioId);
    }
}
