// Parte 1: Calificación
Console.Write("Nota (0-100): ");
if (int.TryParse(Console.ReadLine(), out int nota) && nota >= 0 && nota <= 100)
{
    string letra;
    if (nota >= 90) letra = "A";
    else if (nota >= 80) letra = "B";
    else if (nota >= 70) letra = "C";
    else letra = "F";
    Console.WriteLine($"Letra: {letra}");
}
else
{
    Console.WriteLine("Nota inválida.");
}

// Parte 2: Calculadora
Console.Write("Primer número: ");
double a = double.Parse(Console.ReadLine()!);
Console.Write("Segundo número: ");
double b = double.Parse(Console.ReadLine()!);
Console.Write("Opción (1 sumar, 2 restar, 3 multiplicar, 4 dividir): ");
int op = int.Parse(Console.ReadLine()!);

switch (op)
{
    case 1: Console.WriteLine($"Resultado: {a + b}"); break;
    case 2: Console.WriteLine($"Resultado: {a - b}"); break;
    case 3: Console.WriteLine($"Resultado: {a * b}"); break;
    case 4:
        if (b == 0) Console.WriteLine("No se puede dividir entre 0.");
        else Console.WriteLine($"Resultado: {a / b}");
        break;
    default: Console.WriteLine("Opción inválida."); break;
}