using rlg.Common.Validation;

namespace rlg.Domain.Models
{
  internal static class UsuarioScopes
  {
    public static void nomeUsuarioEhValido(this Usuario usuario, string nome)
    {
      AssertionConcern.AssertArgumentLength(nome, 3, 250, "Nome do usuário inválido");
    }

    public static void emailUsuarioEhValido(this Usuario usuario, string email)
    {
      EmailAssertionConcern.AssertIsValid(email);
    }

    public static void senhaUsuarioEhValido(this Usuario usuario, string senha)
    {
      PasswordAssertionConcern.AssertIsValid(senha);
    }

    public static void definirSenhaUsuarioEhValido(this Usuario usuario, string senha, string confirmarSenha)
    {
      senhaUsuarioEhValido(usuario, senha);
      AssertionConcern.AssertArgumentNotNull(confirmarSenha, "Confirmação de Senha inválida");
      AssertionConcern.AssertArgumentEquals(senha, confirmarSenha, "Senha diferente da confirmação");
      AssertionConcern.AssertArgumentLength(senha, 6, 20, "Senha inválida");
    }

  }
}
