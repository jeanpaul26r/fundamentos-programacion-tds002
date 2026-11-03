/* Nombre: Jean Paul Castro Rivera
   Descripción: Operadores aritméticos y expresiones */
namespace Operadores;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Primer número entero: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Segundo número entero (distinto de 0): ");
        int b = int.Parse(Console.ReadLine()!);

        // Operaciones básicas
        Console.WriteLine($"Suma: {a + b}");
        Console.WriteLine($"Resta: {a - b}");
        Console.WriteLine($"Producto: {a * b}");
        // División real: se convierte uno a double
        Console.WriteLine($"División real: {(double)a / b:F2}");
        Console.WriteLine($"División entera: {a / b}");
        Console.WriteLine($"Residuo: {a % b}");
        // Verifica si el primero es par
        Console.WriteLine($"¿El primero es par?: {a % 2 == 0}");
    }
}

/* PRUEBA DE ESCRITORIO (x = 10, y = 3)

   Línea | Instrucción         | x  | y | Resultado / Salida
   1     | int x = 10, y = 3;  | 10 | 3 |
   2     | x / y               | 10 | 3 | 3  (división entera: 10 / 3)
   3     | x % y               | 10 | 3 | 1  (residuo de 10 / 3)
   4     | x += y;             | 13 | 3 | x vale 13  (x = 10 + 3)
   5     | y++;                | 13 | 4 | y vale 4   (y = 3 + 1)
   6     | x > y && y != 4     | 13 | 4 | false
                                         (13 > 4 es true, 4 != 4 es false;
                                          true && false = false)
*/