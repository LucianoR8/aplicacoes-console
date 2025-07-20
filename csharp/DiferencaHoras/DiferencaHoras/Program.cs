using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaInicio, minutoInicio, horaFim, minutoFim, totalInicio, totalFim, diferenca, horaFinal, minutoFinal;

            Console.WriteLine("Forneça as informações abaixo para saber a duração total");
            Console.Write("Hora de inicio: ");
            horaInicio = int.Parse(Console.ReadLine());

            Console.Write("Minuto de inicio: ");
            minutoInicio = int.Parse(Console.ReadLine());

            Console.Write("Hora final: ");
            horaFim = int.Parse(Console.ReadLine());

            Console.Write("Minuto final: ");
            minutoFim = int.Parse(Console.ReadLine());

            totalInicio = horaInicio * 60 + minutoInicio;
            totalFim = horaFim * 60 + minutoFim;

            if (totalInicio == totalFim)
            {
                Console.WriteLine("Duração de 24 horas e 0 minutos");
            }
            else if (totalInicio > totalFim)
            {
                horaFinal = 24 - horaInicio + horaFim;
                minutoFinal = 60 - minutoInicio + minutoFim;
                if (minutoFinal == 60)
                {
                    minutoFinal = 0;
                }
                Console.WriteLine("Duração de " + horaFinal + " hora(s) e " + minutoFinal + " minutos(s)");
            }
            else
            {
                diferenca = totalFim - totalInicio;
                if (diferenca < 60)
                {
                    Console.WriteLine("Duração de " + diferenca + " minuto(s)");
                }
                else
                {
                    horaFinal = diferenca / 60;
                    minutoFinal = diferenca % 60;
                    Console.WriteLine("Duração de " + horaFinal + " hora(s) e " + minutoFinal + " minuto(s)");
                }
            }








        }
    }
}