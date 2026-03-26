using System;

namespace Desafio_04____Calculadora_de_Fidelidade_Bahia_Fibra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("===VALIDAÇÃO DE DESCONTO - BAHIA FIBRA===");
            Console.WriteLine("===========================================");
            Console.Write("Informe o seu nome completo: ");
            String name = Console.ReadLine();
            Console.Write("Informe a data da sua instalação: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Informe o valor do seu plano: ");
            double preco = double.Parse(Console.ReadLine());

            
            TimeSpan dateDiference = DateTime.Now - date;
            int diasTotais = dateDiference.Days;
            double desconto;
            
            Console.WriteLine("--------------------------------------------");
            if (diasTotais >= 365)
            {
                desconto = preco * 0.10;
                double precoFinal = preco - desconto;
                Console.WriteLine($"O cliente {name} está conosco há {diasTotais} dias.");
                Console.WriteLine($"Ganhou 10% de desconto ({desconto:C2})!");
                Console.WriteLine($"Valor final da mensalidade: {precoFinal:C2}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"O cliente {name} está conosco há {diasTotais} dias.");
                Console.WriteLine($"Ainda não possui desconto. Valor: {preco:C2}");
                Console.ReadKey();
            }

        }
    }
}
