using System;

namespace CalculadoraBahiaFibra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("\n--- PLANOS BAHIA FIBRA ---");
                    Console.WriteLine("1 - 100 MEGA");
                    Console.WriteLine("2 - 200 MEGA");
                    Console.WriteLine("3 - 300 MEGA");
                    Console.WriteLine("0 - Para encerrar o atendimento.");
                    Console.Write("Escolha uma opção: ");

                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Valor do plano: R$ 49,90");
                            break;
                        case "2":
                            Console.WriteLine("Valor do plano: R$ 69,90");
                            break;
                        case "3":
                            Console.WriteLine("Valor do plano: R$ 89,90");
                            break;
                        case "0":
                            Console.WriteLine("Obrigado por escolher a Bahia Fibra, " + nome + "!");
                            continuar = false; // Ajustado para 'continuar'
                            break;
                        default:
                            Console.WriteLine("Plano inválido. Escolha uma opção de 0 a 3.");
                            break;
                    }
                } // Fim do Try
                catch (Exception erro)
                {
                    Console.WriteLine("Ops! Ocorreu um erro: " + erro.Message);
                }
            } // Fim do While

            Console.WriteLine("\nAtendimento encerrado. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}