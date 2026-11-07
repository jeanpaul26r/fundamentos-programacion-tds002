int n;
do
{
    Console.Write("Número entre 1 y 12: ");
} while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 12);

int i = 1;
int suma = 0;
while (i <= 12)
{
    int resultado = n * i;
    Console.WriteLine($"{n} x {i} = {resultado}");
    suma += resultado;
    i++;
}
Console.WriteLine($"Suma de resultados: {suma}");