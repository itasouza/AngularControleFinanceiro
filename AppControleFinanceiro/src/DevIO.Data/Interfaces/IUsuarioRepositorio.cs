﻿
using DevIO.Business.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Data.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        Task<int> PegarQuantidadeUsuariosRegistrados();

        Task<IdentityResult> CriarUsuario(Usuario usuario, string senha);

        Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao);

        Task LogarUsuario(Usuario usuario, bool lembrar);

        Task<Usuario> PegarUsuarioPeloEmail(string email);

        Task<IList<string>> PegarFuncoesUsuario(Usuario usuario);

        Task AtualizarUsuario(Usuario usuario);

    }
}
