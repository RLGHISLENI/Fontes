using System;
using rlg.Common.Validation;

namespace rlg.Domain.Models
{
  public class User
  {

    #region "  Construtor "
    protected User() { }
    public User(string name, string email)
    {
      this.Id = Guid.NewGuid();
      this.Name = name;
      this.Email = email;
    }
    #endregion
 

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public void setPassword(string password, string confirmPassword)
    {
      AssertionConcern.AssertArgumentNotNull(password, "Senha inválida");
      AssertionConcern.AssertArgumentNotNull(confirmPassword, "Confirmação de Senha inválida");
      AssertionConcern.AssertArgumentEquals(password, confirmPassword, "Senha diferente da confirmação");
      AssertionConcern.AssertArgumentLength(password,6,20, "Senha inválida");
    }

  }
}
