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

            string[] vetor = Console.ReadLine().Split(' ');
            W1 = int.Parse(vetor[1]);

            vetor = Console.ReadLine().Split(' ');
            X1 = int.Parse(vetor[0]);
            Y1 = int.Parse(vetor[2]);
            Z1 = int.Parse(vetor[4]);

            vetor = Console.ReadLine().Split(' ');
            W2 = int.Parse(vetor[1]);

            vetor = Console.ReadLine().Split(' ');
            X2 = int.Parse(vetor[0]);
            Y2 = int.Parse(vetor[2]);
            Z2 = int.Parse(vetor[4]);

            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;

            duracao = fim - inicio;

            W = duracao / 86400;
            resto = duracao % 86400;
            X = resto / 3600;
            resto = resto % 3600;
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");



        }
    }
}