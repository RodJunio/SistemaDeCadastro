using System;
using static System.Net.Mime.MediaTypeNames;

namespace SistemaDeCadastro
{
    class Program
    {
        static void Main(string[] agrs)
        {
            List<Cliente> Listaclientes = new List<Cliente>();
            while (true)
            {
                Console.WriteLine(@"Digite: Escola uma opção abaixo
                1 - Para Cadastrar novo cliente
                2 - Listar clientes
                0 - Sair do sistema");

                int opcaoCadastro = int.Parse(Console.ReadLine());


                


                if (opcaoCadastro == 1) {

                    for (int i = 0; i < opcaoCadastro; i++)
                    {
                        Console.WriteLine("Olá! vamos realizar seu cadastro.");
                        Console.WriteLine("Digite seu nome:");
                        string Nome = Console.ReadLine();
                        Console.WriteLine("Digite seu Telefone:");
                        string Telefone = Console.ReadLine();
                        Console.WriteLine("Digite seu Email:");
                        string Email = Console.ReadLine();
                        Cliente clientePadrao = new Cliente(Nome, Telefone, Email); 
                        Listaclientes.Add(clientePadrao);
                    }
                } 
                else if (opcaoCadastro == 2)
                {
                    
                    foreach (Cliente cliente in Listaclientes)
                    {                        
                        Console.WriteLine("\nLISTA DE CLENTES CADASTRADOS:");
                        Console.WriteLine("\n=============================================\n");
                        
                        Console.WriteLine(cliente.Nome);
                        Console.WriteLine(cliente.Telefone);
                        Console.WriteLine(cliente.Email);
                        Console.WriteLine("\n=============================================");
                    }
                } 
                else if (opcaoCadastro == 0)
                {

                    Environment.Exit(0);
                } 
                else
                {
                    Console.WriteLine("Opção inválida");
                }  
                Console.ReadLine();
            }
            
        }
    }
}
