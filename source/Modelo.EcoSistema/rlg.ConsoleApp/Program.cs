using rlg.Domain.Models;
using System;

namespace rlg.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuarioValido = false;
            do
            {
                try
                {
                    Console.WriteLine("Informe os dados para o teste");

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    // Cria usuário 
                    Usuario usuario = new Usuario(nome, email);
                    usuario.definirNomeUsuarioScopesEhValido();
                    usuario.definirEmailUsuarioScopesEhValido();

                    Console.Write("Senha: ");
                    string senha = Console.ReadLine();
                    //usuario.definirSenhaUsuarioScopesEhValido();

                    Console.Write("Confirmação: ");
                    string confirmaSenha = Console.ReadLine();
                    //usuario.definirSenhaUsuarioScopesEhValido(confirmaSenha);

                    // Define senha
                    usuario.definirSenha(senha, confirmaSenha);

                    // Boas vindas e demonstração das informações do usuário
                    Console.WriteLine("Bem Vindo {0}{1}", usuario.Nome, "!");
                    Console.WriteLine("Id: {0}", usuario.Id);
                    Console.WriteLine("Email: {0}", usuario.Email);
                    Console.WriteLine("Senha: {0}", usuario.Senha);
                    usuario.ehValido();
                    Console.WriteLine("Usuário validado com sucesso!");
                    Console.ReadKey();

                    // Troca de nome e redefinição de senha
                    Console.Write("Novo Nome: ");
                    usuario.definirNome(Console.ReadLine());
                    usuario.definirNomeUsuarioScopesEhValido();
                    usuario.redefinirSenha();
                    usuarioValido = usuario.ehValido();

                    Console.WriteLine("Olá {0}", usuario.Nome);
                    Console.WriteLine("Senha Redefinida: {0}", usuario.Senha);
                    Console.WriteLine("Redefinição do usuário validado com sucesso!");
                    Console.ReadKey();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }

            } while (!usuarioValido);

        }
    }
}
