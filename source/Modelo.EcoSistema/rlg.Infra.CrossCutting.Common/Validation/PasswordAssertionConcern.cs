using System.Security.Cryptography;
using System.Text;

namespace rlg.Common.Validation
{
    public class PasswordAssertionConcern
    {
        public static void AssertIsValid(string senha)
        {
            AssertionConcern.AssertArgumentNotNull(senha, "Senha inválida");
        }

        public static string Encrypt(string senha)
        {
            senha += "|1d981cca-f8c0-35c0-bb19-3e85412c6547";
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(senha));
            StringBuilder sbString = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sbString.Append(data[i].ToString("x2"));
            return sbString.ToString();
        }
    }
}
