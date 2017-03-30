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
                    // Teste de visibilidade
                    Pedido pedido = new Pedido(Guid.NewGuid());
                    //pedido.AdicionarItem()

                    Console.WriteLine("Informe os dados para o teste (Nome em branco e <Enter> para sair)");

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    if (string.IsNullOrEmpty(nome))
                        return;

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Senha: ");
                    string senha = Console.ReadLine();

                    Console.Write("Confirmação: ");
                    string confirmaSenha = Console.ReadLine();

                    // Cria usuário e valida todos os atributos
                    Usuario usuario = new Usuario(nome, email, senha, confirmaSenha);

                    // Boas vindas e demonstração das informações do usuário
                    Console.WriteLine("Bem Vindo {0}{1}", usuario.Nome, "!");
                    Console.WriteLine("Id: {0}", usuario.Id);
                    Console.WriteLine("Email: {0}", usuario.Email);
                    Console.WriteLine("Senha: {0}", usuario.Senha);
                    //usuario.ehValido();
                    Console.WriteLine("Usuário validado com sucesso!");
                    Console.ReadKey();

                    // Troca de nome e redefinição de senha
                    Console.Write("Novo Nome: ");
                    usuario.definirNome(Console.ReadLine());
                    usuario.redefinirSenha();
                    //usuarioValido = usuario.ehValido();

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
