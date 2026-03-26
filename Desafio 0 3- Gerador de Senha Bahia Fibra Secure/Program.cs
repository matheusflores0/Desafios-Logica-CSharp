using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_0_3__Gerador_de_Senha_Bahia_Fibra_Secure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("   GERADOR DE SENHA - BAHIA FIBRA    ");
            Console.WriteLine("===========================================");

            Console.Write("Informe o seu nome: ");
            String name = Console.ReadLine();
            Console.Write("Informe o ano em que nasceu: ");
            String age = Console.ReadLine();
            Console.Write("Informe Cidade em que mora: ");
            String city = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Idade: {age}");
            Console.WriteLine($"Cidade: {city}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("--- SENHA GERADA ---");
            Console.WriteLine($"{name.ToUpper()}{age}{city.ToLower()}@BF");
            Console.ReadKey();
        }
    }
}
