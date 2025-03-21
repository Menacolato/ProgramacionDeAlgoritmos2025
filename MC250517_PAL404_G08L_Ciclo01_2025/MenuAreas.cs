using System;

class MenuAreas
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("Menú de Áreas:");
            Console.WriteLine("1. Área de un cuadrado");
            Console.WriteLine("2. Área de un círculo");
            Console.WriteLine("3. Área de un triángulo");
            Console.WriteLine("4. Área exterior de un cilindro");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AreaCuadrado();
                    break;
                case 2:
                    AreaCirculo();
                    break;
                case 3:
                    AreaTriangulo();
                    break;
                case 4:
                    AreaCilindro();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 5);
    }

    static void AreaCuadrado()
    {
        Console.Clear();
        Console.Title = "Área de un cuadrado";
        double lado, area;
        Console.Write("\nDigite el valor del lado: ");
        lado = Convert.ToDouble(Console.ReadLine());
        area = lado * lado;
        Console.WriteLine($"\nEl valor del área del cuadrado es: {Math.Round(area, 2)} cm²");
    }

    static void AreaCirculo()
    {
        Console.Clear();
        Console.Title = "Área de un círculo";
        double radio, area;
        const double Pi = 3.1415;
        Console.Write("\nDigite el valor del radio: ");
        radio = Convert.ToDouble(Console.ReadLine());
        area = Pi * Math.Pow(radio, 2);
        Console.WriteLine($"\nEl valor del área del círculo es: {Math.Round(area, 2)} cm²");
    }

    static void AreaTriangulo()
    {
        Console.Clear();
        Console.Title = "Área de un triángulo";
        double baseTri, altura, area;
        Console.Write("\nDigite el valor de la base: ");
        baseTri = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nDigite el valor de la altura: ");
        altura = Convert.ToDouble(Console.ReadLine());
        area = (baseTri * altura) / 2;
        Console.WriteLine($"\nEl valor del área del triángulo es: {Math.Round(area, 2)} cm²");
    }

    static void AreaCilindro()
    {
        Console.Clear();
        Console.Title = "Área exterior de un cilindro";
        double radio, altura, areaBase, areaLateral, areaTotal;
        const double Pi = 3.1416;
        Console.Write("\nDigite el valor del radio: ");
        radio = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nDigite el valor de la altura: ");
        altura = Convert.ToDouble(Console.ReadLine());
        areaBase = 2 * Pi * Math.Pow(radio, 2);
        areaLateral = 2 * Pi * radio * altura;
        areaTotal = areaBase + areaLateral;
        Console.WriteLine($"\nEl valor del área exterior del cilindro es: {Math.Round(areaTotal, 2)} cm²");
    }
}
