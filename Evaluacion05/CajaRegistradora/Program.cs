// Caja registradora: lee precios hasta que el usuario escriba 0
int productos = 0;       // contador de productos
decimal subtotal = 0;    // acumulador de precios
decimal precio;

do
{
    Console.Write("Precio del producto (0 para terminar): ");

    // Validar que sea número y no negativo
    if (!decimal.TryParse(Console.ReadLine(), out precio) || precio < 0)
    {
        Console.WriteLine("Precio inválido.");
        precio = -1; // fuerza a repetir el ciclo
        continue;
    }

    if (precio > 0)
    {
        productos++;
        subtotal += precio;
    }
} while (precio != 0);

decimal itbis = subtotal * 0.18m;
decimal total = subtotal + itbis;

Console.WriteLine("\n--- RESUMEN ---");
Console.WriteLine($"Productos: {productos}");
Console.WriteLine($"Subtotal:  {subtotal:N2}");
Console.WriteLine($"ITBIS 18%: {itbis:N2}");
Console.WriteLine($"Total:     {total:N2}");