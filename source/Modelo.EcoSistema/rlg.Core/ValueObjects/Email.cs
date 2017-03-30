using System.Text.RegularExpressions;

namespace rlg.Core
{
    public class Email
    {

        #region [  Constantes  ]

        public const int TAMANHO_MAXIMO = 254;
        public const int TAMANHO_MINIMO = 5;

        #endregion

        #region [  Construtor  ]

        protected Email() { }

        public Email(string endereco)
        {
            Endereco = endereco;
        }

        #endregion

        #region [  Propriedades  ]

        public string Endereco { get; private set; }

        #endregion

        #region [  Validação  ]

        public static bool EhValido(string email)
        {
            // Provisório, deve utilizar AssertionConcern
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);
        }

        #endregion

    }
}
