using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
//ejecutarEjercicio1();
//ejecutarEjercicio2();
//ejecutarEjercicio4();
//ejecutarEjercicio5();
//ejecutarEjercicio6();
//ejecutarEjercicio7();
//ejecutarEjercicio8();
//ejecutarEjercicio9();
//ejecutarEjercicio10();
//ejecutarEjercicio11();
//ejecutarEjercicio12();
//ejecutarEjercicio13();
ejecutarEjercicio14();
//ejecutarEjercicio15();
//ejecutarEjercicio16();
//ejecutarEjercicio17();


void ejecutarEjercicio1()
{
    Console.CursorVisible = false;
    ConsoleKeyInfo k = Console.ReadKey(true);
    while (k.Key != ConsoleKey.End)
    {      
        Console.Clear();
        Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
    k = Console.ReadKey(true);
    }
}


void ejecutarEjercicio2()
{
    /*2) Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo de dos
    dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en la misma línea
    en la consola.


    Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la dimensión i.*/


    double[,] matriz = new double[3,3];


    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 3; j++)
        {
            matriz[i,j] = i + j + 0.55;
        }
    }


    imprimirMatriz(matriz);
    imprimirMatrizConFormato(matriz, "0.0");
}


void imprimirMatriz(double[,] matriz)
{
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.WriteLine(matriz[i,j] + "\t");
        }
        Console.WriteLine();
    }
}


void imprimirMatrizConFormato(double[,] matriz, string formatString)
{
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.WriteLine(matriz[i,j].ToString(formatString) + "\t");
        }
        Console.WriteLine();
    }
}


void ejecutarEjercicio4()
{
    double[,] matriz = new double[4,4];


    llenarMatriz(matriz);


    try
    {
        double[] v1 = GetDiagonalPrincipal(matriz);
        double[] v2 = GetDiagonalSecundaria(matriz);


        Console.WriteLine("las diagonales se obtuvieron con exito");


        for(int i = 0; i < v1.Length; i++)
        {
            Console.WriteLine(v1[i] + "\t");
        }


        for(int i = 0; i < v2.Length; i++)
        {
            Console.WriteLine(v2[i] + "\t");
        }


    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error de validacion {ex.Message}");
    }
}


double[] GetDiagonalPrincipal(double[,] matriz)
{
    if(matriz.GetLength(0) != matriz.GetLength(1))
    {
        throw new ArgumentException("la matriz no es cuadrada");
    }


    double[] vector = new double[matriz.GetLength(0)];
    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        vector[i] = matriz[i,i];
    }
    return vector;
}


double[] GetDiagonalSecundaria(double[,] matriz)
{
    if(matriz.GetLength(0) != matriz.GetLength(1))
    {
        throw new ArgumentException("la matriz no es cuadrada");
    }


    int n = matriz.GetLength(0);
    double[] vector = new double[matriz.GetLength(0)];
    for(int i = 0; i < n; i++)
    {
        vector[i] = matriz[i, n - 1 - i];
    }
    return vector;
}


void llenarMatriz(double[,] matriz)
{
    Random random = new Random();


    for(int i = 0; i < matriz.GetLength(0); i++)
    {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            matriz[i,j] = Math.Round(random.NextDouble() * 100, 1);
        }
    }
}


void ejecutarEjercicio5()
{
    double[,] matriz = new double[4,4];


    llenarMatriz(matriz);


    double[][] arreglo = GetArregloDeArreglo(matriz);
}


double[][] GetArregloDeArreglo(double[,] matriz)
{
    int fila = matriz.GetLength(0);
    int columna = matriz.GetLength(1);


    double[][] arreglo = new double[fila][];


    for(int i = 0; i < fila; i++)
    {
        arreglo[i] = new double[columna];


        for(int j = 0; j < columna ; j++)
        {
            arreglo[i][j] = matriz[i, j];
        }
    }


    return arreglo;
}


void ejecutarEjercicio6()
{
    double[,] matrizA = new double[3,4];
    double[,] matrizB = new double[4,3];


    llenarMatriz(matrizA);
    llenarMatriz(matrizB);


    try
    {
        double[,]? suma = calcularSuma(matrizA, matrizB);
        double[,]? resta = calcularResta(matrizA, matrizB);


        if(suma != null)
        {
            Console.WriteLine("suma exitosa");
            imprimirMatriz(suma);
            Console.WriteLine("resta exitosa");
            imprimirMatriz(resta);
        } else
        {
            Console.WriteLine("las matrices no son cuadradas");    
        }






        double[,] multiplicacion = calcularMultiplicacion(matrizA, matrizB);
        Console.WriteLine("multiplicacion exitosa");
        imprimirMatriz(multiplicacion);
    }
    catch(ArgumentException exp)
    {
        Console.WriteLine($"error de validacion {exp.Message}");
    }
}


double[,]? calcularSuma(double[,]? A, double[,]? B)
{
    if((A.GetLength(0) == B.GetLength(0)) && (A.GetLength(1) == B.GetLength(1))){
        int fila = A.GetLength(0);
        int columna = A.GetLength(1);
        double[,] suma = new double[fila, columna];


        for(int i = 0; i < fila; i++)
        {
            for(int j = 0; j < columna; j++)
            {
                suma[i,j] = A[i,j] + B[i,j];
            }
        }


        return suma;
    } else
    {
        return null;
    }
}


double[,]? calcularResta(double[,]? A, double[,]? B)
{
    if((A.GetLength(0) == B.GetLength(0)) && (A.GetLength(1) == B.GetLength(1))){
        int fila = A.GetLength(0);
        int columna = A.GetLength(1);
        double[,] resta = new double[fila, columna];


        for(int i = 0; i < fila; i++)
        {
            for(int j = 0; j < columna; j++)
            {
                resta[i,j] = A[i,j] - B[i,j];
            }
        }


        return resta;
    } else
    {
        return null;
    }
}


double[,]? calcularMultiplicacion(double[,]? A, double[,]? B)
{
   


    if(A.GetLength(1) == B.GetLength(0))
    {
        int filasA = A.GetLength(0);
        int columnasA = A.GetLength(1);
        int columnasB = B.GetLength(1);


        double[,] mul = new double[filasA, columnasB];


        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasB; j++)
            {
                double suma = 0;
                for (int k = 0; k < columnasA; k++)
                {
                    suma += A[i, k] * B[k, j];
                }
                mul[i, j] = suma;
            }
        }


        return mul;
    } else
    {
        throw new ArgumentException("no coincide el tamano de la fila con el de la columna");
    }
}


void ejecutarEjercicio7()
{
    //7) ¿De qué tipo quedan definidas las variables x, y, z en el siguiente código?


    int i = 10;
    var x = i * 1.0;
    var y = 1f;
    var z = i * y;


    Console.WriteLine("Tipo de i: " + i.GetType());
    Console.WriteLine("Tipo de x: " + x.GetType());
    Console.WriteLine("Tipo de y: " + y.GetType());
    Console.WriteLine("Tipo de z: " + z.GetType());
}  


void ejecutarEjercicio8()
{
    //Senalar errores de compilacion o ejecucion


    object obj = new int[10];
    dynamic dyna = 13;
    //Console.WriteLine(obj.Length); no existe una propiedad .Length para una variable de tipo Objeto
    //Console.WriteLine(dyna.Length); la variable de tipo dynamic se saltea las restricciones y asume que, como 13 es un int, no habra
    //problema en hacer un .Length pero no existe dicha propiedad en los int
}


void ejecutarEjercicio9()
{
    //que lineas tienen errores?


    var a = 3L;
    dynamic b = 32;
    object obj = 3;
    //a = a * 2.0; se requiere hacer casting
    b = b * 2.0;
    b = "hola";
    obj = b;
    b = b + 11;
    //obj = obj + 11; no se puede aplicar el operador + a una variable tipo object
    var c = new { Nombre = "Juan" };
    var d = new { Nombre = "María" };
    var e = new { Nombre = "Maria", Edad = 20 };
    var f = new { Edad = 20, Nombre = "Maria" };
    //f.Edad = 22; es solo read only, no tiene un setter
    d = c;
    //e = d; diferente cantidad de campos
    //f = e; diferente orden de campos
}


void ejecutarEjercicio10()
{
    /*10) Verificar con un par de ejemplos si la sección opcional [:formatString] de formatos
    compuestos redondea o trunca cuando se formatean números reales restringiendo la cantidad de
    decimales. Plantear los ejemplos con cadenas de formato compuesto y con cadenas interpoladas.*/


    double num1 = 1.30239;
    float num2 = 1.3424f;


    Console.WriteLine("formato compuesto: El valor {0} con un decimal es: {0:0.0}", num1);
    Console.WriteLine("formato compuesto: El valor {0} con un decimal es: {0:0.0}", num2);
    Console.WriteLine($"cadena interpolada: El valor{num1} con dos decimales es: {num1:0.00}");
    Console.WriteLine($"cadena interpolada: El valor{num2} con dos decimales es: {num2:0.00}");
}


void ejecutarEjercicio11()
{
    List<int> a = [ 1, 2, 3, 4 ];
    //a.Remove(5); //no existe el elemento 5
    //a.RemoveAt(4); //no hay elemento en la posicion 4
}


void ejecutarEjercicio12()
{
    string cadena = "(()())";


    if (verificarCadena(cadena))
    {
        Console.WriteLine("la cadena esta balanceada");
    } else
    {
        Console.WriteLine("La cadena NO esta balanceada");
    }
}


bool verificarCadena(string cadena)
{
    Stack<string> pila = new Stack<string>();


    for(int i = 0; i < cadena.Length; i++)
    {
        char c = cadena[i];
        if (c.Equals('('))
        {
            pila.Push(c.ToString());
        } else if(pila.Count == 0)
        {
            return false;
        } else
        {
            pila.Pop();
        }
    }
    if(pila.Count == 0)
    {
        return true;
    } else
    {
        return false;
    }
}


void ejecutarEjercicio13()
{
    Console.WriteLine("ingrese un numero en decimal");
    string num = Console.ReadLine();


    int numero = int.Parse(num);


    int binario = obtenerBinario(numero);


    Console.WriteLine("el numero binario es {0}", binario);
}


int obtenerBinario(int numero)
{
    Stack<int> pila = new Stack<int>();
    while(numero >= 2)
    {
        int resto = numero % 2;
        pila.Push(resto);
        numero /= 2;
    }
    pila.Push(numero);


    int lim = pila.Count;
    string cadena = "";
    int num;
    for(int i = 0; i < lim; i++)
    {
        num = pila.Pop();
        cadena = cadena + num;
    }
    int c = int.Parse(cadena);
    return c;
}


void ejecutarEjercicio14()
{
    Console.WriteLine("Ingrese una clave");
    string c = Console.ReadLine();
    int clave = int.Parse(c);


    Console.WriteLine("ingrese un mensaje");
    string mensaje = Console.ReadLine();


    string cifrado = obtenerCifrado(clave, mensaje);


    Console.WriteLine("El mensaje cifrado es {0}", cifrado);
}


string obtenerCifrado(int clave, string mensaje)
{
    Queue<int> cola = new Queue<int>();
    string contra = clave.ToString();


    foreach(char c in contra)
    {
        cola.Enqueue(c - '0');
    }


    char[] letras = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ".ToCharArray();
    System.Text.StringBuilder mensajeCifrado = new System.Text.StringBuilder();


    foreach(char c in mensaje.ToUpper())
    {
        int pos = -1;
        for(int j = 0; j < letras.Length; j++)
        {
            if(letras[j] == c)
            {
                pos = j;
                break;
            }
        }


        if(pos != -1)
        {
            int digito = cola.Dequeue();


            int nuevaPos = (pos + digito) % 28;


            mensajeCifrado.Append(letras[nuevaPos]);


            cola.Enqueue(digito);
        }
    }
    return mensajeCifrado.ToString();
}




void ejecutarEjercicio15()
{
    int x = 0;
    try
    {
        Console.WriteLine(1.0 / x);
        Console.WriteLine(1 / x);
        Console.WriteLine("todo ok");
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}


void ejecutarEjercicio16()
{
    string? num="";
    double numero;
    double suma = 0;
    do{
        Console.WriteLine("Ingrese un numero");
        num = Console.ReadLine();


        if (!string.IsNullOrEmpty(num))
        {
            try
            {
                numero = double.Parse(num);
                suma += numero;
            }
            catch (FormatException)
            {
                Console.WriteLine("caracter invalido");
            }
        }


    } while (!string.IsNullOrEmpty(num));


    Console.WriteLine("la suma es: {0}", suma);
}


void ejecutarEjercicio17()
{
    try{
        Metodo1();
    }
    catch
    {
        Console.WriteLine("Método 1 propagó una excepción no tratada");
    }


    try
    {
        Metodo2();
    }
    catch
    {
        Console.WriteLine("Método 2 propagó una excepción no tratada");
    }


    try
    {
        Metodo3();
    }
    catch
    {
        Console.WriteLine("Método 3 propagó una excepción");
    }
}


void Metodo1()
{
    object obj = "hola";
    try
    {
        int i = (int) obj;
    }
    finally
    {
        Console.WriteLine("Bloque finally en Metodo1");
    }
}


void Metodo2()
{
    object obj = "hola";
    try
    {
        int i = (int)obj;
    }
    catch(OverflowException)
    {
        Console.WriteLine("Overflow");
    }
}


void Metodo3()
{
    object obj = "hola";


    try
    {
        int i = (int)obj;
    }
    catch (InvalidCastException)
    {
        Console.WriteLine("Excepcion InvalidCast en Metodo3");
        throw;
    }
}

