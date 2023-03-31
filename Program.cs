using System;
using System.Globalization;

namespace CsE6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCICIO 6
            Console.WriteLine("Calculando area de formas geometricas\n\n" +
            "Informe três valores (Ex: 3.0 (Enter) 4.0 (Enter) 5.2 (Enter)):\n");

            //COLETA DE DADOS
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //CÁLCULOS
            double trianguloR = a * c / 2;
            double circulo = 3.14159 * c * c;
            double trapezio = (a + b) * c / 2;
            double quadrado = b * b;
            double retangulo = a * b;

            //RETORNO DE DADOS
            Console.WriteLine("\nTRIANGULO: " + (trianguloR.ToString("F3", CultureInfo.InvariantCulture)));
            Console.WriteLine("CIRCULO: " + (circulo.ToString("F3", CultureInfo.InvariantCulture)));
            Console.WriteLine("TRAPEZIO: " + (trapezio.ToString("F3", CultureInfo.InvariantCulture)));
            Console.WriteLine("QUADRADO: " + (quadrado.ToString("F3", CultureInfo.InvariantCulture)));
            Console.WriteLine("RETANGULO: " + (retangulo.ToString("F3", CultureInfo.InvariantCulture)));
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
