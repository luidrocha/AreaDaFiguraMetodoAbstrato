using System;
using System.Collections.Generic;
using AreaFiguraMetodosAbstratos.Entities;
using AreaFiguraMetodosAbstratos.Entities.Enuns;
using System.Globalization;

namespace AreaFiguraMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Figura> lista = new List<Figura>();

            
            Console.Write("Digite a quantidade de Figuras: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int x =1; x<=qtd; x++)
            {

                Console.WriteLine($"Figura {x} Dados");
                Console.WriteLine();
                Console.Write("Qual o tipo de Figura (R) Retangulo (C) Circulo: ");
                string tf = Console.ReadLine();
                
                Console.Write("Cor do Objeto (P) Preta (V) Vermelha (D) Verde:  ");
                Color cor =  (Color)Enum.Parse(typeof(Color),Console.ReadLine());
                

                if (tf=="R" || tf=="r")
                {
                    Console.Write("Digite a Altura do Retangulo");
                    double al = double.Parse(Console.ReadLine());

                    Console.Write("Digite a Largura do Retangulo");
                    double lg = double.Parse(Console.ReadLine());

                    Figura figura = new Retangulo(al,lg, cor);

                    lista.Add(figura);

                } else
                {
                    Console.Write("Digite  Raio ");
                    double raio = double.Parse(Console.ReadLine());

                    Figura figura = new Circulo(raio, cor);

                    lista.Add(figura);

                }

                

            }

            Console.WriteLine("Areas das figuras: ");

            foreach(Figura figura in lista)
            {

                Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));


            }
        }
    }
}
