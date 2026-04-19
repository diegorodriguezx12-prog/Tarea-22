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

Console.Write("\n¿Qué fila desea ver? (0 a " + (filas - 1) + "): ");
int filaSeleccionada = int.Parse(Console.ReadLine());

if (filaSeleccionada >= 0 && filaSeleccionada < filas)
{
    Console.WriteLine("Valores de la fila " + filaSeleccionada + ":");
    for (int c = 0; c < columnas; c++)
    {
        Console.Write(matriz[filaSeleccionada, c] + "\t");
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Esa fila no existe.");
}