using System.Text.RegularExpressions;

namespace rlg.Common.Validation
{
    public class EmailAssertionConcern
    {
        public static void AssertIsValid(string email)
        {
            AssertionConcern.AssertArgumentMatches(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                                                   RegexOptions.IgnoreCase,
                                                   email,
                                                   "Email inválido");
            //if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            //  throw new Exception("Email inválido");
        }
    }
}
