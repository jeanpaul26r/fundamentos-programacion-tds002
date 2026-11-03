/* Nombre: Jean Paul Castro Rivera
   Descripción: Casting explícito e implícito */
namespace Casting;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Número con decimales: ");
        double numero = double.Parse(Console.ReadLine()!);

        // Casting explícito: double -> int (se pierden los decimales)
        int parteEntera = (int)numero;
        Console.WriteLine($"Número: {numero}");
        Console.WriteLine($"Parte entera (casting explícito): {parteEntera}");

        // Casting implícito: int -> double (automático, sin pérdida)
        int entero = 7;
        double enteroComoDouble = entero;
        Console.WriteLine($"Casting implícito: int {entero} -> double {enteroComoDouble}");
    }
}