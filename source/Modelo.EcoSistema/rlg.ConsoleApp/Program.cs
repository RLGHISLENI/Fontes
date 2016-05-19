using System;
using System.Windows;
using rlg.Domain.Models;


namespace rlg.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        User usuario = new User("Robertinho", "beto.ghisleni@gmail.com");
        usuario.setPassword("1234567890", "1234567890");

        Console.WriteLine("Bem Vindo " + usuario.Name + "!");
        Console.WriteLine("Id: " + usuario.Id );
        Console.WriteLine("Email: " + usuario.Email);
        Console.WriteLine("Senha: " + usuario.Password);
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
