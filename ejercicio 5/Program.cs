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

Console.Write("\nIngrese el número que desea buscar: ");
int numeroBuscar = int.Parse(Console.ReadLine());

bool encontrado = false;

for (int f = 0; f < filas; f++)
{
    for (int c = 0; c < columnas; c++)
    {
        if (matriz[f, c] == numeroBuscar)
        {
            Console.WriteLine("El número " + numeroBuscar + " se encuentra en la posición: Fila " + f + ", Columna " + c);
            encontrado = true;
        }
    }
}

if (encontrado == false)
{
    Console.WriteLine("El número no se encuentra en la matriz.");
}