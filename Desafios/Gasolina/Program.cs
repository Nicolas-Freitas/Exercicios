using System;

namespace Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            int vel;
            int tempo;
            int dist;
            int litros;

            Console.WriteLine("Qual a velocidade média?");
            vel = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto foi o tempo gasto na viagem em horas?");
            tempo = int.Parse(Console.ReadLine());

            dist = tempo*vel;
            litros = dist/12;

            System.Console.WriteLine($"A quantidade de gasolina usada foi de {litros} litros");
        }
    }
}
