using System;
using rlg.Domain.Models;

namespace rlg.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        // Cria usuário e define senha
        Usuario usuario = new Usuario("Robertinho", "beto.ghisleni@gmail.com");
        usuario.definirSenha("1234567890", "1234567890");

        // Boas vindas e demonstraçã das informações do usuário
        Console.WriteLine("Bem Vindo " + usuario.Nome + "!");
        Console.WriteLine("Id: " + usuario.Id );
        Console.WriteLine("Email: " + usuario.Email);
        Console.WriteLine("Senha: " + usuario.Senha);
        usuario.Validar();
        Console.WriteLine("Usuário validado com sucesso!");
        Console.ReadKey();

        // Troca de nome e redefinição de senha
        usuario.AlterarNome("Beto Ghisleni");
        usuario.redefinirSenha();
        Console.WriteLine("Novo Nome: " + usuario.Nome);
        Console.WriteLine("Senha Redefinida: " + usuario.Senha);
        usuario.Validar();
        Console.WriteLine("Redefinição do usuário validado com sucesso!");
        Console.ReadKey();

      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.ReadKey();
      }      
    }
  }
}
