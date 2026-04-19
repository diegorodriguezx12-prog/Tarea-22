Console.Write("Ingrese la cantidad de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];

for (int f = 0; f < filas; f++)
{
    for (int c = 0; c < columnas; c++)
    {
        Console.Write("Ingrese el valor para [" + f + "," + c + "]: ");
        matriz[f, c] = int.Parse(Console.ReadLine());
    }
}

int mayor = matriz[0, 0];

for (int f = 0; f < filas; f++)
{
    for (int c = 0; c < columnas; c++)
    {
        if (matriz[f, c] > mayor)
        {
            mayor = matriz[f, c];
        }
    }
}

Console.WriteLine("\nLa matriz es:");
for (int f = 0; f < filas; f++)
{
    for (int c = 0; c < columnas; c++)
    {
        Console.Write(matriz[f, c] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nEl número mayor encontrado es: " + mayor);