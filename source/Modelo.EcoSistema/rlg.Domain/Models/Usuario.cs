using System;
using rlg.Common.Validation;

namespace rlg.Domain.Models
{
  public class Usuario
  {

    #region Construtor

    protected Usuario() { }

    public Usuario(string nome, string email)
    {
      Id = Guid.NewGuid();
      Nome = nome;
      Email = email;
    }

    #endregion

    #region Propriedades

    public Guid Id { get; private set; }

    public string Nome { get; private set; }

    public string Email { get; private set; }

    public string Senha { get; private set; }

    #endregion

    #region Métodos

    public void definirSenha(string senha, string confirmarSenha)
    {
      AssertionConcern.AssertArgumentNotNull(senha, "Senha inválida");
      AssertionConcern.AssertArgumentNotNull(confirmarSenha, "Confirmação de Senha inválida");
      AssertionConcern.AssertArgumentEquals(senha, confirmarSenha, "Senha diferente da confirmação");
      AssertionConcern.AssertArgumentLength(senha, 6, 20, "Senha inválida");

      Senha = PasswordAssertionConcern.Encrypt(senha);
    }

    public string redefinirSenha()
    {
      string senha= Guid.NewGuid().ToString().Substring(0, 8);
      Senha= PasswordAssertionConcern.Encrypt(senha);
      return senha;
    }

    public void AlterarNome(string nome)
    {
      Nome = nome;
    }

    public void Validar()
    {
      AssertionConcern.AssertArgumentLength(Nome, 3, 250, "Nome do usuário inválido");
      EmailAssertionConcern.AssertIsValid(Email);
      PasswordAssertionConcern.AssertIsValid(Senha);
    }

    #endregion

  }
}
