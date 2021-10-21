using System;
using System.Collections.Generic;
using System.Globalization;
using Método_abstrato.Entities;

namespace Método_abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação da lista da classe "forma"
            List<Forma> list = new List<Forma>();
            Console.WriteLine("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Forma #{i}:");
                Console.Write("Retângulo ou Circulo(R / C) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor: (Preto / Azul / Vermelho): ");
                Color cor = Enum.Parse<Color>(Console.ReadLine());

                //if para escolher a forma, instanciando o objeto e adicionando na lista
                if (ch == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }

                Console.WriteLine();
                Console.WriteLine("Área de cada forma geométrica: ");

                //foreach para a conversão dos números para string
                foreach (Forma forma in list)
                {
                    Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
