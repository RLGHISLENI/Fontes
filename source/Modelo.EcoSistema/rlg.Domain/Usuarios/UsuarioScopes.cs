using rlg.Common.Validation;

namespace rlg.Domain.Models
{
    public static class UsuarioScopes
    {
        internal static void definirNomeUsuarioScopesEhValido(this Usuario usuario)
        {
            AssertionConcern.AssertArgumentLength(usuario.Nome, Usuario.NOME_TAMANHO_MINIMO, Usuario.NOME_TAMANHO_MAXIMO, "Nome do usuário inválido");
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
            AssertionConcern.AssertArgumentNotNull(confirmarSenha, "Confirmação de Senha inválida");
            AssertionConcern.AssertArgumentEquals(usuario.Senha, confirmarSenha, "Senha diferente da confirmação");
            AssertionConcern.AssertArgumentLength(usuario.Senha, Usuario.SENHA_TAMANHO_MINIMO, Usuario.SENHA_TAMANHO_MAXIMO, "Senha deve conter no mínimo 6 e no máximo 20 caracteres.");
        }

    }
}
