using rlg.Common.Validation;
using rlg.Domain.Usuarios.Resources;

namespace rlg.Domain.Models
{
    public static class UsuarioScopes
    {
        internal static void definirNomeUsuarioScopesEhValido(this Usuario usuario)
        {
            AssertionConcern.AssertArgumentLength(usuario.Nome, 
                Usuario.NOME_TAMANHO_MINIMO, 
                Usuario.NOME_TAMANHO_MAXIMO, UsuarioResource.NomeInvalido);
        }

        internal static void definirEmailUsuarioScopesEhValido(this Usuario usuario)
        {
            EmailAssertionConcern.AssertIsValid(usuario.Email);
        }

        internal static void definirSenhaUsuarioScopesEhValido(this Usuario usuario)
        {
            PasswordAssertionConcern.AssertIsValid(usuario.Senha);
        }

        internal static void definirSenhaUsuarioScopesEhValido(this Usuario usuario, string confirmarSenha)
        {
            definirSenhaUsuarioScopesEhValido(usuario);

            AssertionConcern.AssertArgumentNotNull(confirmarSenha, 
                UsuarioResource.SenhaNaoConfirmada);

            AssertionConcern.AssertArgumentEquals(usuario.Senha, 
                confirmarSenha, 
                UsuarioResource.SenhaDiferente);

            AssertionConcern.AssertArgumentLength(usuario.Senha, 
                Usuario.SENHA_TAMANHO_MINIMO, 
                Usuario.SENHA_TAMANHO_MAXIMO, 
                string.Format(UsuarioResource.SenhaInvalida, new object[] {
                    Usuario.SENHA_TAMANHO_MINIMO,
                    Usuario.SENHA_TAMANHO_MAXIMO
                }
            ));
        }

    }
}
