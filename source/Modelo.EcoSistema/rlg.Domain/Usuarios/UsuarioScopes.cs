using rlg.Common.Validation;

namespace rlg.Domain.Models
{
  public static class UsuarioScopes
  {
    public static void nomeUsuarioEhValido(this Usuario usuario)
    {
      AssertionConcern.AssertArgumentLength(usuario.Nome, 3, 250, "Nome do usuário inválido");
    }

    public static void emailUsuarioEhValido(this Usuario usuario)
    {
      EmailAssertionConcern.AssertIsValid(usuario.Email);
    }

    public static void senhaUsuarioEhValido(this Usuario usuario)
    {
      PasswordAssertionConcern.AssertIsValid(usuario.Senha);
    }

    public static void definirSenhaUsuarioEhValido(this Usuario usuario, string confirmarSenha)
    {
      senhaUsuarioEhValido(usuario);
      AssertionConcern.AssertArgumentNotNull(confirmarSenha, "Confirmação de Senha inválida");
      AssertionConcern.AssertArgumentEquals(usuario.Senha, confirmarSenha, "Senha diferente da confirmação");
      AssertionConcern.AssertArgumentLength(usuario.Senha, 6, 20, "Senha deve conter no mínimo 6 e no máximo 20 caracteres.");
    }

  }
}
