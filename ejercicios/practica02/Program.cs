using System;
using System.Text;

//ejecutarEjercicio1();
//ejecutarEjercicio2();
//ejecutarEjercicio3();
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
//ejecutarEjercicio14();
//ejecutarEjercicio15();
//ejecutarEjercicio16();
//ejecutarEjercicio17();
//ejecutarEjercicio18();
//ejecutarEjercicio19();
//ejecutarEjercicio20();
ejecutarEjercicio21();

void ejecutarEjercicio1()
{
    /*El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas variables están
    apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la consola no sea “Z Z”?*/

    object o1 = "A"; //creo una variable que apunta a "A"
    object o2 = o1; //creo otra variable que apunta a la misma zona de memoria
    o2 = "Z"; //como le asigno un nuevo valor, ahora estoy apuntando a otra zona de memoria
    Console.WriteLine(o1 + " " + o2);
}

void ejecutarEjercicio2()
{
    /*2)  Qué líneas del siguiente código provocan conversiones boxing y unboxing.*/

    char c1 = 'A'; // asignacion
    string st1 = "A"; //asignacion
    object o1 = c1; //boxing
    object o2 = st1; //asignacion
    char c2 = (char)o1; //unboxing, desde heap a stack
    string st2 = (string)o2; //asignacion
}

void ejecutarEjercicio3()
{
    //3) ¿Qué diferencias existen entre las conversiones de tipo implícitas y explícitas ?

    //las conversiones implicitas no corren riesgo, el programa las realiza sin necesidad de hacer algun casting, en las conversiones explicitas el programador debe realizar una conversion
}

void ejecutarEjercicio4()
{
    /*4) Resolver los errores de compilación en el siguiente fragmento de código.Utilizar el operador as
    cuando sea posible. */

    object o = "Hola Mundo!";
    string st = o as string;
    int i = 12;
    byte b = (byte)i;
    double d = i;
    float f = (float)d;
    o = i;
    i = (int)o + 1;

}

void ejecutarEjercicio5()
{
    //5) Qué líneas del siguiente código provocan conversiones boxing y unboxing.

    char c1 = 'A'; //asignacion
    string st1 = "A"; //asignacion
    object o1 = c1; //boxing
    object o2 = st1; //asignacion
    char c2 = (char)o1; //unboxing
    string st2 = (string)o2; //conversion explicita
}

void ejecutarEjercicio6()
{
    /*6) Supongamos que Program.cs sólo tiene las siguientes dos líneas:
    Por que no cimpila?*/

    //int i;
    //Console.WriteLine(i);

    //porque i no esta inicializada
}

void ejecutarEjercicio7()
{
    /*7)¿Cuál es la salida por consola del siguiente fragmento de código ? ¿Por qué la tercera y sexta línea
    producen resultados diferentes?*/

    char c1 = 'A';
    char c2 = 'A';
    Console.WriteLine(c1 == c2);
    object o1 = c1;
    object o2 = c2;
    Console.WriteLine(o1 == o2);

    //la primer linea da true, porque esta comparando si los valoreson iguales, la segunda linea da false, porque, al ser variables dentro del heap,
    //la igualdad == indica si estan en la misma direccion de memoria.
}

void ejecutarEjercicio8()
{
    /*8) Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué
    circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar un
    caso de ejemplo en el que el rendimiento sea claramente superior utilizando StringBuilder en lugar
    de string y otro en el que no.*/

    //las variables de tipo StringBuilder son como los strings pero a diferencia de estas si son mutables, o sea que podemos modificarlas sin tener
    //que crear otro espacio en memoria, es preferible usarlas en casos en las que tengamos que modificar un texto muchas veces

    string resultado = "";
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < 50000; i++)
    {
        sb.Append(i); // aca es mejor usar un stringBuilder y no un string
    }
    resultado = sb.ToString();
    Console.WriteLine(resultado);
}

void ejecutarEjercicio9()
{
    /*9)Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos
    implementados en el ejercicio anterior.*/

    DateTime dt = DateTime.Now.Date;

    Console.WriteLine("Fecha y hora actual: " + dt);

    DateTime dt2 = new DateTime(2005, 12, 23, 14, 30, 00);

    Console.WriteLine("Fecha programada: " + dt2);

    Console.WriteLine("Solo la fecha: " + dt2.ToString("d"));
    Console.WriteLine("Solo la hora: " + dt2.ToString("HH:mm"));
}

void ejecutarEjercicio10()
{
    /*10) Comprobar el funcionamiento del siguiente programa y dibujar el estado de la pila y la memoria
    heap cuando la ejecución alcanza los puntos indicados(comentarios en el código)*/

    object[] v = new object[10]; //al crear el arreglo, todas las referencias apuntan a lo mismo: null
    v[0] = new StringBuilder("Net"); //hago que mi primera posicion apunte a una nueva zona de memoria

    for (int i = 1; i < 10; i++)
    {
        v[i] = v[i - 1]; //hago que todas mis posiciones apunten a la misma zona de memoria que v[0]
    }

    (v[5] as StringBuilder).Insert(0, "Framework ."); //como se cambia el contenido, esto se ve afectado en todas las posiciones, ya que todas apntan a lo mismo

    foreach (StringBuilder s in v)
        Console.WriteLine(s);

    //dibujar el estado de la pila y la mem. heap
    //en este punto de la ejecución

    v[5] = new StringBuilder("CSharp"); //hago que v[5] apunte a otra zona de memoria

    foreach (StringBuilder s in v)
        Console.WriteLine(s);

    //dibujar el estado de la pila y la mem. heap
    //en este punto de la ejecución
}

void ejecutarEjercicio11()
{
    /*11) ¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas las
    palabras(una por línea) de una frase ingresada por consola por el usuario.*/

    //el metodo split sirve para dividir una cadena de texto en un subarreglo con cada palabra en cada posicion
    Console.WriteLine("Ingrese una frase");
    string frase = Console.ReadLine();

    string[] palabras = frase.Split();

    foreach (string p in palabras)
    {
        Console.WriteLine(p);
    }
}

void ejecutarEjercicio12()
{
    /*12) Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
    a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso(diciembre,
    noviembre, octubre …, enero)
    b) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al nombre de
    un mes
    Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses*/



    for (Meses m = Meses.Diciembre; m >= Meses.Enero; m--)
    {
        Console.WriteLine(m);
        if (m == Meses.Enero)
        {
            break;
        }
    }

    Console.WriteLine("\ningrese el nombre de un mes");
    string mes = Console.ReadLine();

    for (Meses m = Meses.Enero; m <= Meses.Diciembre; m++)
    {
        if (m.ToString().Equals(mes))
        {
            Console.WriteLine("texto encontrado");
            break;
        }
    }
}

void ejecutarEjercicio13()
{
    //13) ¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?
    //False, 0

    Console.WriteLine(args == null);
    Console.WriteLine(args.Length);
}

void ejecutarEjercicio14()
{
    //14) ¿Qué hace la instrucción? ¿Asigna a la variable vector el valor null ?
    int[]? vector = new int[0]; //se guarda la direccion de memoria donde se aloja el vector, a pesar de no tenr nada, igualmente esta en la heap

    Console.WriteLine(vector == null); //false
}

void ejecutarEjercicio15()
{
    //15) Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros cuando
    //se invoca desde la línea de comandos.

    Console.WriteLine("¡Hola {0}!", args[0]); //si no se pasan argumentos tira error, si se pasan argumentos se imprime el texto
}

void ejecutarEjercicio16()
{
    //16) Escribir un programa que reciba una lista de nombres como parámetro por la línea de comandos e
    //imprima por consola un saludo personalizado para cada uno de ellos.
    //a) Utilizando la sentencia for
    //b) Utilizando la sentencia foreach

    if (args.Length != 0)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Saludos a " + args[i]);
        }
    }
    else
    {
        Console.WriteLine("No se pasaron nombres en la linea de comandos");
    }

}

void ejecutarEjercicio17()
{
    /*17) Implementar un programa que muestre todos los números primos entre 1 y un número natural dado
    (pasado al programa como argumento por la línea de comandos).Definir el método bool
    EsPrimo(int n) que devuelve true sólo si n es primo.Esta función debe comprobar si n es
    divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota: Math.Sqrt(d) devuelve la
    raíz cuadrada de d)*/

    if (args.Length != 0)
    {
        int limite = int.Parse(args[0]);

        for (int i = 1; i <= limite; i++)
        {
            if (EsPrimo(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    else
    {
        Console.WriteLine("No se ingresaron numeros");
    }

}

bool EsPrimo(int n)
{
    if (n <= 1) return false;
    if (n == 2) return true;

    int raiz = (int)Math.Sqrt(n);
    for (int i = 2; i <= raiz; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

void ejecutarEjercicio18()
{
    /*18) Escribir una función(método int Fac(int n)) que calcule el factorial de un número n pasado al
    programa como parámetro por la línea de comando
    a) Definiendo una función no recursiva
    b) Definiendo una función recursiva
    c) idem a b) pero con expression - bodied methods(Tip: utilizar el operador condicional ternario)*/

    if (args.Length != 0)
    {
        int n = int.Parse(args[0]);
        //Console.WriteLine("El resultado es: " + FacNoRecursivo(n));
        //Console.WriteLine("El resultado es: " + FacRecursivo(n));
        Console.WriteLine("El resultado es: " + FacExpressionBodied(n));
    }
    else
    {
        Console.WriteLine("No se pasaron parametros");
    }

}

int FacRecursivo(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * FacRecursivo(n - 1);
    }
}

int FacNoRecursivo(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        int res = 1;
        for (int i = n; i >= 1; i--)
        {
            res *= i;
        }
        return res;
    }
}

int FacExpressionBodied(int n) => (n == 0) ? 1 : n * FacExpressionBodied(n - 1);

void ejecutarEjercicio19()
{
    //19) Idem.al ejercicio 18.a) y 18.b) pero devolviendo el resultado en un parámetro de salida void
    //Fac(int n, out int f)

    if (args.Length != 0)
    {
        int num = int.Parse(args[0]);
        int f;

        FacNoRecursivoOut(num, out f);
        Console.WriteLine("el resultado NO utilizando recursion es: " + f);

        FacRecursivoOut(num, out f);
        Console.WriteLine("El resultado utilizando recursion es: " + f);
    }
}

void FacRecursivoOut(int n, out int f)
{
    if (n == 0)
    {
        f = 1;
    }
    else
    {
        f = n * FacRecursivo(n - 1);
    }
}

void FacNoRecursivoOut(int n, out int f)
{
    int aux = 1;
    for (int i = 1; i <= n; i++)
    {
        aux *= i;
    }
    f = aux;
}

void ejecutarEjercicio20()
{
    /*20) Codificar el método Swap que recibe 2 parámetros enteros e intercambia sus valores. El cambio
    debe apreciarse en el método invocador.*/

    if (args.Length > 1)
    {
        int num1 = int.Parse(args[0]);
        int num2 = int.Parse(args[1]);
        Console.WriteLine($"Lo valores antes del swap son {num1} y {num2}");
        Swap(ref num1, ref num2);
        Console.WriteLine($"Lo valores ahora son: {num1} y {num2}");
    }

}

void Swap(ref int num1, ref int num2)
{
    int aux = num1;
    num1 = num2;
    num2 = aux;
}

void ejecutarEjercicio21()
{
    /*21) Codificar el método Imprimir para que el siguiente código produzca la salida por consola que se
    observa.Considerar que el usuario del método Imprimir podría querer más adelante imprimir otros
    datos, posiblemente de otros tipos pasando una cantidad distinta de parámetros cada vez que invoque el
    método.Tip: usar params*/

    Imprimir(1, "casa", 'A', 3.4, DayOfWeek.Saturday);
    Imprimir(1, 2, "tres");
    Imprimir();
    Imprimir("-------");
    Imprimir(1, 2, 3, "hola", 'A');

}

void Imprimir(params object[] args)
{
    foreach (object e in args)
    {
        Console.Write(e + " ");
    }
    Console.WriteLine();
}
enum Meses
{
    Enero,
    Febrero,
    Marzo,
    Abril,
    Mayo,
    Junio,
    Julio,
    Agosto,
    Septiembre,
    Octubre,
    Noviembre,
    Diciembre
}

