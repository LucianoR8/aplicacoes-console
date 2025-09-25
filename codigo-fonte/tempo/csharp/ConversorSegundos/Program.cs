using System;
using System.Formats.Asn1;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numero, horas, minutos, segundos, resto;
            Console.Write("Informe em segundos o tempo a ser convertido: ");
            numero = int.Parse(Console.ReadLine());

            horas = numero / 3600;
            resto = numero % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine("Tempo: " + horas + " horas, " + minutos + " minutos, " + segundos + " e segundos");




        }
    }
}