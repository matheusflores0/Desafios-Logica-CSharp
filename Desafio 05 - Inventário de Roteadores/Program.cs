using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_05___Inventário_de_Roteadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> routers = new List<String>();
            Console.WriteLine("===== INVENTÁRIO DE EQUIPAMENTOS - BAHIA FIBRA =====");

            for (int i = 1; i <= 5; i++) {
                Console.WriteLine($"Digite o modelo do {i} roteador: ");
                String modelo = Console.ReadLine();

                routers.Add(modelo);

            }
            Console.Clear();
            Console.WriteLine("======= RELATÓRIO FINAL DE ESTOQUE =======");

            foreach (String item in routers)
            {
                Console.WriteLine($"- Modelo: {item}");
            }
        }
    }
}
