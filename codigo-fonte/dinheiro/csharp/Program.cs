using System;
using System.Formats.Asn1;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double valor;
            int nota, moeda, resto, resultado;

            Console.Write("Informe o valor que você quer separar: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(valor * 100 + 0.05);



            Console.WriteLine("Notas:");

            nota = 100;
            resultado = resto / (nota * 100);
            Console.WriteLine(resultado + " nota(s) de R$100.00");
            resto = resto % (nota * 100);

            nota = 50;
            resultado = resto / (nota * 100);
            Console.WriteLine(resultado + " nota(s) de R$50.00");
            resto = resto % (nota * 100);

            nota = 20;
            resultado = resto / (nota * 100);
            Console.WriteLine(resultado + " nota(s) de R$20.00");
            resto = resto % (nota * 100);

            nota = 10;
            resultado = resto / (nota * 100);
            Console.WriteLine(resultado + " nota(s) de R$10.00");
            resto = resto % (nota * 100);

            nota = 5;
            resultado = resto / (nota * 100);
            Console.WriteLine(resultado + " nota(s) de R$5.00");
            resto = resto % (nota * 100);

            nota = 2;
            resultado = resto / (nota * 100);
            Console.WriteLine(resultado + " nota(s) de R$2.00");
            resto = resto % (nota * 100);

            Console.WriteLine("Moedas:");

            moeda = 100;
            resultado = resto / moeda;
            Console.WriteLine(resultado + " moeda(s) de 1 real");
            resto = resto % moeda;

            moeda = 50;
            resultado = resto / moeda;
            Console.WriteLine(resultado + " moeda(s) de cinquenta centavos");
            resto = resto % moeda;

            moeda = 25;
            resultado = resto / moeda;
            Console.WriteLine(resultado + " moeda(s) de vinte e cinco centavos");
            resto = resto % moeda;

            moeda = 10;
            resultado = resto / moeda;
            Console.WriteLine(resultado + " moeda(s) de 10 centavos");
            resto = resto % moeda;

            moeda = 5;
            resultado = resto / moeda;
            Console.WriteLine(resultado + " moeda(s) de 5 centavos");
            resto = resto % moeda;


            Console.WriteLine("Faltaram: " + resto + " centavos para completar o valor");





        }
    }
}
