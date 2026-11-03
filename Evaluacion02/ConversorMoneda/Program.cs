/* Nombre: Jean Paul Castro Rivera
   Descripción: Conversor de pesos dominicanos a dólares */
namespace ConversorMoneda;
class Program
{
    // Tasa del día (cámbiala por la tasa real de hoy)
    const double TASA_USD = 60.50;

    static void Main(string[] args)
    {
        Console.Write("Monto en pesos (DOP): ");
        double montoPesos = double.Parse(Console.ReadLine()!);

        // Conversión a dólares
        double montoDolares = montoPesos / TASA_USD;

        Console.WriteLine($"Tasa del día: {TASA_USD:F2} DOP por USD");
        Console.WriteLine($"{montoPesos:F2} DOP = {montoDolares:F2} USD");
    }
}