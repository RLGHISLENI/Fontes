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
      definirNome(nome);
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
      UsuarioScopes.definirSenhaUsuarioEhValido(this, senha, confirmarSenha);
      Senha = PasswordAssertionConcern.Encrypt(senha);
    }

    public string redefinirSenha()
    {
      string senha = Guid.NewGuid().ToString().Substring(0, 8);
      Senha = PasswordAssertionConcern.Encrypt(senha);
      return senha;
    }

    public void definirNome(string nome)
    {
      UsuarioScopes.nomeUsuarioEhValido(this, nome);
      Nome = nome;
    }

    public void validar()
    {
      UsuarioScopes.nomeUsuarioEhValido(this, Nome);
      UsuarioScopes.emailUsuarioEhValido(this, Email);
      UsuarioScopes.senhaUsuarioEhValido(this, Senha);
    }

    #endregion

  }
}
