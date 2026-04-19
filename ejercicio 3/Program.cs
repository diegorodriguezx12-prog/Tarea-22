Console.Write("Ingrese la cantidad de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];
int sumaTotal = 0;

for (int f = 0; f < filas; f++)
{
    for (int c = 0; c < columnas; c++)
    {
        Console.Write("Ingrese el valor para [" + f + "," + c + "]: ");
        matriz[f, c] = int.Parse(Console.ReadLine());
        sumaTotal = sumaTotal + matriz[f, c];
    }
}

Console.WriteLine("\nMatriz ingresada:");
for (int f = 0; f < filas; f++)
{
    for (int c = 0; c < columnas; c++)
    {
        Console.Write(matriz[f, c] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nLa suma total de todos los elementos es: " + sumaTotal);