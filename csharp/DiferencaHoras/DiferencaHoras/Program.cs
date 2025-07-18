using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaInicio, minutoInicio, horaFim, minutoFim, totalInicio, totalFim, diferenca, horaFinal, minutoFinal;
            string[] vetor = Console.ReadLine().Split(' ');
            horaInicio = int.Parse(vetor[0]);
            minutoInicio = int.Parse(vetor[1]);
            horaFim = int.Parse(vetor[2]);
            minutoFim = int.Parse(vetor[3]);

            totalInicio = horaInicio * 60 + minutoInicio;
            totalFim = horaFim * 60 + minutoFim;

            if (totalInicio == totalFim)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if (totalInicio > totalFim)
            {
                horaFinal = 23 - horaInicio + horaFim;
                minutoFinal = 60 - minutoInicio + minutoFim;
                if (minutoFinal == 60)
                {
                    minutoFinal = 0;
                }
                Console.WriteLine("O JOGO DUROU " + horaFinal + " HORA(S) E " + minutoFinal + " MINUTO(S)");
            }
            else
            {
                diferenca = totalFim - totalInicio;
                if (diferenca < 60)
                {
                    Console.WriteLine("O JOGO DUROU 0 HORA(S) E " + diferenca + " MINUTO(S)");
                }
                else
                {
                    horaFinal = diferenca / 60;
                    minutoFinal = diferenca % 60;
                    Console.WriteLine("O JOGO DUROU " + horaFinal + " HORA(S) E " + minutoFinal + " MINUTO(S)");
                }
            }








        }
    }
}