/* Nombre: Jean Paul Castro Rivera
   Descripción: Conversor de unidades (libras a kg y °F a °C) */
namespace Secuencial;
class Program
{
    // 1 libra = 0.453592 kg
    const double KG_POR_LIBRA = 0.453592;

    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Peso en libras: ");
        double libras = double.Parse(Console.ReadLine()!);

        Console.Write("Temperatura en °F: ");
        double fahrenheit = double.Parse(Console.ReadLine()!);

        // Proceso
        double kilogramos = libras * KG_POR_LIBRA;
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Salida
        Console.WriteLine($"{libras:F2} lb equivalen a {kilogramos:F2} kg");
        Console.WriteLine($"{fahrenheit:F2} °F equivalen a {celsius:F2} °C");
    }
}