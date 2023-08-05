using System;
using System.Collections.Generic;

namespace GerenciamentoDeContatos
{
    class Contato
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }

    class Program
    {
        static List<Contato> contatos = new List<Contato>();

        static void Main()
        {
            Console.WriteLine("Bem-vindo ao Gerenciamento de Contatos!");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Adicionar contato");
                Console.WriteLine("2 - Visualizar contatos");
                Console.WriteLine("3 - Sair");

                Console.Write("\nEscolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        VisualizarContatos();
                        break;
                    case "3":
                        Console.WriteLine("Encerrando o programa. Até logo!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarContato()
        {
            Console.WriteLine("\nAdicionar contato:");

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Telefone: ");
            var telefone = Console.ReadLine();

            // Validando se os campos obrigatórios não estão vazios
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telefone))
            {
                contatos.Add(new Contato { Nome = nome, Email = email, Telefone = telefone });
                Console.WriteLine("Contato adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro: Preencha todos os campos obrigatórios (Nome, Email, Telefone).");
            }
        }

        static void VisualizarContatos()
        {
            Console.WriteLine("\nContatos:");

            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato registrado.");
            }
            else
            {
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"Nome: {contato.Nome}, Email: {contato.Email}, Telefone: {contato.Telefone}");
                }
            }
        }
    }
}
