/* Nombre: Jean Paul Castro Rivera
   Descripción: Cálculo de nómina con descuentos AFP y SFS */
namespace Nomina;
class Program
{
    // Porcentajes de descuento
    const double TASA_AFP = 0.0287;
    const double TASA_SFS = 0.0304;

    static void Main(string[] args)
    {
        // Entrada
        Console.Write("Nombre del empleado: ");
        string nombre = Console.ReadLine()!;
        Console.Write("Horas trabajadas: ");
        double horas = double.Parse(Console.ReadLine()!);
        Console.Write("Pago por hora: ");
        double pagoHora = double.Parse(Console.ReadLine()!);

        // Proceso
        double salarioBruto = horas * pagoHora;
        double afp = salarioBruto * TASA_AFP;
        double sfs = salarioBruto * TASA_SFS;
        double salarioNeto = salarioBruto - afp - sfs;

        // Salida
        Console.WriteLine($"\nEmpleado: {nombre.ToUpper()}");
        Console.WriteLine($"Salario bruto: {salarioBruto:N2}");
        Console.WriteLine($"AFP (2.87%):   {afp:N2}");
        Console.WriteLine($"SFS (3.04%):   {sfs:N2}");
        Console.WriteLine($"Salario neto:  {salarioNeto:N2}");
    }
}