// Adivina el número: secreto entre 1 y 100
int secreto = Random.Shared.Next(1, 101);
int intentos = 0;   // contador de intentos
int numero;

do
{
    Console.Write("Adivina el número (1-100): ");

    // Validar entrada para evitar excepciones
    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Escribe un número válido.");
        continue; // no cuenta como intento
    }

    intentos++;

    if (numero < secreto) Console.WriteLine("Mayor");
    else if (numero > secreto) Console.WriteLine("Menor");
} while (numero != secreto);

Console.WriteLine($"¡Acertaste! Intentos: {intentos}");