// Programa de divisibilidad

Console.WriteLine("Bienvenido al programa de divisibilidad.");

// Mostrar opciones al usuario
Console.WriteLine("1) Imprimir los números del 1 al 50 que son divisibles por 3");
Console.WriteLine("2) Imprimir los números del 50 al 100 que son múltiplos de 7");
Console.Write("Elige una opción (1 o 2): ");

// Leer la opción ingresada
int opcion = int.Parse(Console.ReadLine()!);

// Evaluar la opción elegida
if (opcion == 1)
{
    Console.WriteLine("Números del 1 al 50 que son divisibles por 3:");
    for (int i = 1; i <= 50; i++)
    {
        if (i % 3 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
else if (opcion == 2)
{
    Console.WriteLine("Números del 50 al 100 que son múltiplos de 7:");
    for (int i = 50; i <= 100; i++)
    {
        if (i % 7 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("Opción inválida. Reinicia el programa y elige 1 o 2.");
}

// Espera para cerrar el programa
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();

// Mensaje de cierre de programa
Console.WriteLine("El programa fue creado por Josue Mena. ¡Gracias!");
