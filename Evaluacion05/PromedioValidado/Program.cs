// Promedio validado: notas 0-100, termina con -1
int cantidad = 0;     // contador de notas
int suma = 0;         // acumulador
int mayor = 0;
int menor = 100;
int nota;

while (true)
{
    // do-while: repite hasta que la nota sea válida (0-100) o -1
    do
    {
        Console.Write("Nota (0-100, -1 para terminar): ");
    } while (!int.TryParse(Console.ReadLine(), out nota)
             || (nota != -1 && (nota < 0 || nota > 100)));

    if (nota == -1) break;

    cantidad++;
    suma += nota;
    if (nota > mayor) mayor = nota;
    if (nota < menor) menor = nota;
}

if (cantidad == 0)
{
    Console.WriteLine("No se ingresaron notas.");
}
else
{
    double promedio = (double)suma / cantidad;
    Console.WriteLine($"Promedio: {promedio:N2}");
    Console.WriteLine($"Nota mayor: {mayor}");
    Console.WriteLine($"Nota menor: {menor}");
}