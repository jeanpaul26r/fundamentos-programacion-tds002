/* Nombre: Jean Paul Castro Rivera
   Fecha: 2026-11-03
   Descripción: Variables, constantes y tipos de datos */
namespace Variables;
class Program
{
    // Constante del año actual
    const int ANIO_ACTUAL = 2026;

    static void Main(string[] args)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        Console.Write("Estatura (cm): ");
        double estatura = double.Parse(Console.ReadLine()!);

        // Año de nacimiento
        int anioNacimiento = ANIO_ACTUAL - edad;

        Console.WriteLine($"Hola {nombre}, tienes {edad} años, naciste en {anioNacimiento} y mides {estatura:F2} cm.");
    }
}