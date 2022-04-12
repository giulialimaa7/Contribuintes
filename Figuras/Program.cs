using System;
using System.Collections.Generic;
using Contribuintes.Entidades;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuidor> lista = new List<Contribuidor>();

            Console.Write("Entre com o número de contribuidores: ");
            int c = int.Parse(Console.ReadLine());

            for (int i=1; i<=c; i++)
            {
                Console.WriteLine($"Dados do contribuidor {i}:");
                Console.Write("Pessoa física ou jurídica (f/j)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if (tipo == 'f')
                {
                    Console.Write("Gasto com saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine());
                    lista.Add(new Fisica(nome, rendaAnual, gastoSaude));
                }
                else
                {
                    Console.Write("Número de funcionário: ");
                    int numeroFuncionario = int.Parse(Console.ReadLine());
                    lista.Add(new Juridica(nome, rendaAnual, numeroFuncionario));
                }
            }
            double soma = 0;
            Console.WriteLine();
            Console.WriteLine("IMPSOTOS:");

            foreach (Contribuidor contribuidor in lista)
            {
                double imposto = contribuidor.Imposto();
                Console.WriteLine(contribuidor.Nome + ": " + "$ " + imposto.ToString("f2"));
                soma = soma + imposto;
            }
            Console.WriteLine("TOTAL DE IMPOSTO: " + "$ " + soma.ToString("f2"));

        }
    }
}
