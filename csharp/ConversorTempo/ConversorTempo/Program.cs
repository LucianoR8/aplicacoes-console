using System;
using System.Formats.Asn1;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int W, X, Y, Z, W1, X1, Y1, Z1, W2, X2, Y2, Z2, inicio, fim, duracao, resto;
            Console.WriteLine("Contagem de tempo em dias diferentes (leia o arquivo de funcionamento do código)");
            Console.WriteLine(" ");

            Console.Write("Dia de inicio: ");
            W1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Hora de inicio: ");
            X1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Minuto inicial: ");
            Y1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Segundo inicial: ");
            Z1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Dia de termino: ");
            W2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Hora de termino: ");
            X2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Minuto final: ");
            Y2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Segundo final: ");
            Z2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;

            duracao = fim - inicio;

            W = duracao / 86400;
            resto = duracao % 86400;
            X = resto / 3600;
            resto = resto % 3600;
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine("Duração de: ");
            Console.WriteLine(" ");
            Console.Write(W + " dia(s) ");
            Console.Write(X + " hora(s) ");
            Console.Write(Y + " minuto(s) ");
            Console.Write(Z + " e segundo(s)");



        }
    }
}