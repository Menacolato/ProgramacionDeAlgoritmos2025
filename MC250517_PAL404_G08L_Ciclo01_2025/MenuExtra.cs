using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("Menú:");
            Console.WriteLine("a) Seno de x.");
            Console.WriteLine("b) Coseno de x.");
            Console.WriteLine("c) Tangente de x.");
            Console.WriteLine("d) Raíz cuadrada de x.");
            Console.WriteLine("e) Potencia de Y².");
            Console.WriteLine("f) Verificar si un número es par o impar.");
            Console.WriteLine("g) Salir del programa.");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (opcion)
            {
                case 'a':
                    CalcularSeno();
                    break;
                case 'b':
                    CalcularCoseno();
                    break;
                case 'c':
                    CalcularTangente();
                    break;
                case 'd':
                    CalcularRaizCuadrada();
                    break;
                case 'e':
                    CalcularPotencia();
                    break;
                case 'f':
                    VerificarParImpar();
                    break;
                case 'g':
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 'g');
    }

    static void CalcularSeno()
    {
        Console.Write("Ingrese el valor de x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"El seno de {x} es {Math.Sin(x)}");
    }

    static void CalcularCoseno()
    {
        Console.Write("Ingrese el valor de x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"El coseno de {x} es {Math.Cos(x)}");
    }

    static void CalcularTangente()
    {
        Console.Write("Ingrese el valor de x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"La tangente de {x} es {Math.Tan(x)}");
    }

    static void CalcularRaizCuadrada()
    {
        Console.Write("Ingrese el valor de x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        if (x >= 0)
            Console.WriteLine($"La raíz cuadrada de {x} es {Math.Sqrt(x)}");
        else
            Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
    }

    static void CalcularPotencia()
    {
        Console.Write("Ingrese el valor de Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"La potencia de {y}² es {Math.Pow(y, 2)}");
    }

    static void VerificarParImpar()
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
            Console.WriteLine($"{numero} es par.");
        else
            Console.WriteLine($"{numero} es impar.");
    }
}