//ejecutarEjercicio1();
using System.Numerics;

ejecutarEjercicio2();

void ejecutarEjercicio1()
{
    //ejecutar el siguiente programa:

    Console.CursorVisible = false;
    ConsoleKeyInfo k = Console.ReadKey(true);
    while (k.Key != ConsoleKey.End)
    {
        Console.Clear();
        Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
        k = Console.ReadKey(true);
    }

    /*Comprobar tipeando teclas y modificadores(shift, ctrl, alt) para apreciar de qué manera se
    puede acceder a esta información en el código del programa*/

    //lee las teclas q ingresamos y nos proporciona informacion acerca de estas
}

void ejecutarEjercicio2()
{
    /*2) Implementar un método para imprimir por consola todos los elementos de una matriz(arreglo de dos
    dimensiones) pasada como parámetro.Debe imprimir todos los elementos de una fila en la misma línea
    en la consola*/

    double[,] arreglo = new double[3][3];
    int c = 0;

    for (int i = 0; i < arreglo.Length; i++)
    {
        for (int j = 0; j < arreglo[i].Length; j++)
        {
            arreglo[i][j] = c;
            c++;
        }
    }
}

void imprimirMatriz(double[,] matriz)
{
    for (int i = 0; i < matriz.Length; i++)
    {
        for (int j = 0; j < matriz[i].Length; j++)
        {
            Console.WriteLine(matriz[i][j]);
        }
    }
}