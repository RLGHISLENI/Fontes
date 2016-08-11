using rlg.Common.Validation;
using System;

namespace rlg.Domain.Models
{
    public class Usuario
    {

        #region [  Constantes  ]

        public const short NOME_TAMANHO_MINIMO = 6;
        public const short NOME_TAMANHO_MAXIMO = 35;

        public const short SENHA_TAMANHO_MINIMO = 4;
        public const short SENHA_TAMANHO_MAXIMO = 15;

        #endregion

        #region [  Construtor  ]

        protected Usuario() { }

        public Usuario(string nome, string email)
        {
            Id = Guid.NewGuid();
            definirNome(nome);
            Email = email;
        }

        #endregion

        #region [  Propriedades  ]

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Senha { get; private set; }

        #endregion

        #region [  Métodos  ]

        public void definirSenha(string senha, string confirmarSenha)
        {
            Senha = senha;
            this.definirSenhaUsuarioScopesEhValido(confirmarSenha);
            Senha = PasswordAssertionConcern.Encrypt(senha);
        }

        public string redefinirSenha()
        {
            var senha = Guid.NewGuid().ToString().Substring(0, 8);
            Senha = PasswordAssertionConcern.Encrypt(senha);
            return senha;
        }

        public void definirNome(string nome)
        {
            Nome = nome;
            this.definirNomeUsuarioScopesEhValido();
        }

        public bool ehValido()
        {
            this.definirNomeUsuarioScopesEhValido();
            this.definirEmailUsuarioScopesEhValido();
            this.definirSenhaUsuarioScopesEhValido();
            return true;
        }

        #endregion

    }
}
