/* Nombre: Jean Paul Castro Rivera
   Descripción: Ficha personal con tipos de datos */
namespace FichaPersonal;
class Program
{
    // Año actual como constante
    const int ANIO_ACTUAL = 2026;

    static void Main(string[] args)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        Console.Write("Estatura (cm): ");
        double estatura = double.Parse(Console.ReadLine()!);

        Console.Write("¿Trabaja? (true/false): ");
        bool trabaja = bool.Parse(Console.ReadLine()!);

        // Año en que cumplirá 30 años
        int anioTreinta = ANIO_ACTUAL - edad + 30;

        Console.WriteLine("\n===== FICHA PERSONAL =====");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura:F2} cm");
        Console.WriteLine($"Trabaja: {trabaja}");
        Console.WriteLine($"Cumplirá 30 años en: {anioTreinta}");
    }
}