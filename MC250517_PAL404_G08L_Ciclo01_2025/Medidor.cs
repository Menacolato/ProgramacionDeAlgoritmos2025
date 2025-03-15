using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] temperaturas = new double[7];
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        Console.WriteLine("Ingrese las temperaturas de cada día de la semana:");

        for (int i = 0; i < dias.Length; i++)
        {
            while (true)
            {
                Console.Write($"Temperatura de {dias[i]}: ");
                if (double.TryParse(Console.ReadLine(), out temperaturas[i]))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                }
            }
        }

        double promedio = temperaturas.Average();
        double tempMin = temperaturas.Min();
        double tempMax = temperaturas.Max();
        int bajoCero = temperaturas.Count(t => t < 0);
        double porcentajeBajoCero = (bajoCero / 7.0) * 100;

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"- Promedio de temperatura semanal: {promedio:F2}°C");
        Console.WriteLine($"- Temperatura más fría: {tempMin}°C");
        Console.WriteLine($"- Temperatura más calurosa: {tempMax}°C");
        Console.WriteLine($"- Porcentaje de temperaturas bajo cero: {porcentajeBajoCero:F2}%");
    }
}

