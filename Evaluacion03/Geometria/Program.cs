/* Nombre: Jean Paul Castro Rivera
   Descripción: Área y circunferencia de un círculo, hipotenusa de un triángulo */
namespace Geometria;
class Program
{
    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Radio del círculo: ");
        double radio = double.Parse(Console.ReadLine()!);
        Console.Write("Cateto 1: ");
        double cateto1 = double.Parse(Console.ReadLine()!);
        Console.Write("Cateto 2: ");
        double cateto2 = double.Parse(Console.ReadLine()!);

        // Proceso
        double area = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;
        double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

        // Salida
        Console.WriteLine($"\nÁrea del círculo: {area:F2}");
        Console.WriteLine($"Circunferencia: {circunferencia:F2}");
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
    }
}