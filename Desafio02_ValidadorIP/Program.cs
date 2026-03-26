using System;

namespace Desafio02_ValidadorIP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("===========================================");
            Console.WriteLine("   SISTEMA DE DIAGNÓSTICO - BAHIA FIBRA    ");
            Console.WriteLine("===========================================");

            Console.Write("Informe o seu nome: ");
            string name = Console.ReadLine();

            
            while (true)
            {
                Console.WriteLine($"\nOlá {name}, digite o IP para análise (ou '0' para sair):");
                string ip = Console.ReadLine();

                
                if (ip == "0")
                {
                    Console.WriteLine("\nEncerrando o sistema... Até logo!");
                    break; 
                }

                
                if (ip.Length < 7)
                {
                    Console.WriteLine(">>> ERRO: IP inválido! Muito curto para ser um IPv4.");
                }

                
                else if (ip.StartsWith("10.50"))
                {
                    Console.WriteLine(">>> DIAGNÓSTICO: Backbone/Gerência Bahia Fibra.");
                }
                else if (ip.StartsWith("192.168"))
                {
                    Console.WriteLine(">>> DIAGNÓSTICO: Rede Interna (Roteador do Cliente).");
                }
                else
                {
                    Console.WriteLine(">>> DIAGNÓSTICO: Rede Externa (WAN/Internet).");
                }

                
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}