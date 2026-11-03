/* Nombre: Jean Paul Castro Rivera
   Descripción: Factura con ITBIS en columnas alineadas */
namespace Factura;
class Program
{
    // ITBIS del 18 %
    const double TASA_ITBIS = 0.18;

    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Producto: ");
        string producto = Console.ReadLine()!;
        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine()!);
        Console.Write("Precio unitario: ");
        double precio = double.Parse(Console.ReadLine()!);

        // Proceso
        double subtotal = cantidad * precio;
        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        // Salida en columnas alineadas
        Console.WriteLine("\n========== FACTURA ==========");
        Console.WriteLine($"{"Producto".PadRight(15)}{"Cant.",5}{"Precio",12}");
        Console.WriteLine($"{producto.PadRight(15)}{cantidad,5}{precio,12:N2}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"{"Subtotal:".PadRight(15)}{subtotal,17:N2}");
        Console.WriteLine($"{"ITBIS (18%):".PadRight(15)}{itbis,17:N2}");
        Console.WriteLine($"{"TOTAL:".PadRight(15)}{total,17:N2}");
    }
}