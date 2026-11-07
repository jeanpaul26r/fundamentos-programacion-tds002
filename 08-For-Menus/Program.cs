int opcion;
do
{
    Console.WriteLine("\n1. Tablas");
    Console.WriteLine("2. Triángulo");
    Console.WriteLine("0. Salir");
    Console.Write("Opción: ");
    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:
            for (int f = 1; f <= 10; f++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    Console.Write($"{f * c,4}");
                }
                Console.WriteLine();
            }
            break;

        case 2:
            Console.Write("Número de filas: ");
            if (int.TryParse(Console.ReadLine(), out int filas) && filas > 0)
            {
                for (int f = 1; f <= filas; f++)
                {
                    for (int c = 1; c <= f; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Número inválido.");
            break;

        case 0:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
} while (opcion != 0);