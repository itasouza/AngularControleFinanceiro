namespace DevIO.Data.Interfaces
{
    public interface IGraficoRepositorio
    {
        object PegarGanhosAnuaisPeloUsuarioId(string usuarioId, int ano);

        object PegarDespesasAnuaisPeloUsuarioId(string usuarioId, int ano);
    }
}
