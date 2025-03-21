using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, int> votos = new Dictionary<int, int>
        {
            {1, 0},
            {2, 0},
            {3, 0},
            {4, 0}
        };

        int totalVotos = 0;
        int voto;

        Console.WriteLine("Ingrese los votos (1, 2, 3, 4) y termine con 0:");

        do
        {
            voto = Convert.ToInt32(Console.ReadLine());
            if (voto >= 1 && voto <= 4)
            {
                votos[voto]++;
                totalVotos++;
            }
            else if (voto != 0)
            {
                Console.WriteLine("Voto no válido. Por favor, ingrese un número entre 1 y 4.");
            }
        } while (voto != 0);

        Console.WriteLine("\nResultados de la elección:");
        foreach (var candidato in votos)
        {
            double porcentaje = (double)candidato.Value / totalVotos * 100;
            Console.WriteLine($"Candidato {candidato.Key}: {candidato.Value} votos ({porcentaje:F2}%)");
        }
    }
}
