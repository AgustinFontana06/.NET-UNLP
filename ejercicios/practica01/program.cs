using System;

Console.WriteLine("Seminario .net - ejercicios practica 1");

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


void ejecutarEjercicio1()
{
    /*1) Consultar en la documentación de Microsoft y responder cuál es la diferencia entre los métodos
    WriteLine() y Write() de la clase System.Console ¿Cómo funciona el método ReadKey() de
    la misma clase? Escribir un programa que imprima en la consola la frase “Hola Mundo” haciendo una
    pausa entre palabra y palabra esperando a que el usuario presione una tecla para continuar.
    Tip: usar los métodos ReadKey() y Write() de la clase System.Console*/

    Console.Write("Hola ");
    Console.ReadKey();
    Console.Write("mundo!");
}

void ejecutarEjercicio2()
{
    /*2) Investigar por las secuencias de escape \n, \t , \" y \\. Escribir un programa que las utilice para
    imprimir distintos mensajes en la consola.*/


    Console.WriteLine("hola\nchau");
    Console.ReadKey();
    Console.WriteLine("Nombre:\tAgustin\nEdad:\t20");
    Console.ReadKey();
    Console.WriteLine("Ruta: C:\\Archivos\\Documento.txt");
}

void ejecutarEjercicio3()
{
    /*3) El carácter @ delante de un string desactiva los códigos de escape. Probar el siguiente fragmento
    de código, eliminar el carácter @ y utilizar las secuencias de escape necesarias para que el programa
    siga funcionando de igual manera*/

    string st = @"c:\windows\system";
    Console.WriteLine(st);

    string st2 = "c:\\windows\\system";
    Console.WriteLine(st2);
}

void ejecutarEjercicio4()
{
    /*4) Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un saludo
    personalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una línea en blanco.
    Para ingresar un string desde el teclado utilizar Console.ReadLine()*/

    Console.WriteLine("Ingrese su nombre");
    string nombre = Console.ReadLine();

    if (nombre != " ")
    {
        Console.WriteLine("Buenos dias " + nombre);
    }
    else
    {
        Console.WriteLine("Hola mundo");
    }
}

void ejecutarEjercicio5()
{
    /*5) Idem.al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el
    nombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María” debe
    imprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso, debe
    imprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha ingresado una línea
    vacía.
    a) utilizando if ... else if
    b) utilizando switch*/

    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Ingrese su nombre");
        string nombre = Console.ReadLine();

        //con if
        /*if (nombre == "Juan")
        {
            Console.WriteLine("¡Hola amigo!");
        }
        else if (nombre == "Maria")
        {
            Console.WriteLine("Buenos dias señora");
        }
        else if (nombre == "Alberto")
        {
            Console.WriteLine("Hola Alberto");
        }
        else if (nombre != "")
        {
            Console.WriteLine("Hola " + nombre);
        }
        else
        {
            Console.WriteLine("Hola Mundo!");
        }*/

        //con switch:

        switch (nombre)
        {
            case "Juan":
                Console.WriteLine("¡Hola amigo!");
                break;
            case "Maria":
                Console.WriteLine("Buenos dias señora");
                break;
            case "Alberto":
                Console.WriteLine("Hola Alberto");
                break;
            case "":
                Console.WriteLine("Hola Mundo");
                break;
            default:
                Console.WriteLine("Hola " + nombre);
                break;
        }
    }

}

void ejecutarEjercicio6()
{
    /*6) Utilizar Console.ReadLine() para leer líneas de texto(secuencia de caracteres que finaliza al
    presionar<ENTER>) por la consola.Por cada línea leída se debe imprimir inmediatamente la cantidad
    de caracteres de la misma. El programa termina al ingresar la cadena vacía.
    Tip: si st es una variable de tipo string, entonces st.Length devuelve la cantidad de caracteres del
    string.*/

    Console.WriteLine("Ingrese una cadena");
    string cadena = Console.ReadLine();
    while (cadena != "")
    {
        Console.WriteLine("tamaño de la cadena: " + cadena.Length);
        Console.WriteLine("Ingrese una cadena");
        cadena = Console.ReadLine();
    }

    Console.WriteLine("no se ingreso ninguna cadena de texto");
}

void ejecutarEjercicio7()
{
    /*7) Que hace la instruccion Console.WriteLine("100".Length)?*/
    Console.WriteLine("100".Length);
    //imprime la cantidad de caracteres del string
}

void ejecutarEjercicio8()
{
    /* 8) Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:
     Console.WriteLine(st = Console.ReadLine());?*/

    string st = "Hola";
    Console.WriteLine(st = Console.ReadLine());
    //es correcto, se asigna un valor a st y se imprime en una sola linea
}

void ejecutarEjercicio9()
{
    /*9)Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>, y
    determinar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).
    Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1]
    devuelve el último carácter de st.*/

    Console.WriteLine("Ingrese una palabra");
    string st1 = Console.ReadLine();
    Console.ReadKey();
    Console.WriteLine("Ingrese otra palabra");
    string st2 = Console.ReadLine();

    if (st1.Length == st2.Length)
    {
        int c1 = 0;
        int c2 = st2.Length - 1;
        for (int i = 1; i < st1.Length; i++)
        {
            if (st1[c1] == st2[c2])
            {
                c1++;
                c2--;
            }
            else
            {
                Console.WriteLine("Las palabras no son simetricas");
                break;
            }
        }
        Console.WriteLine("Las palabras son simetricas");
    }
    else
    {
        Console.WriteLine("Las palabras no son simetricas");
    }
}

void ejecutarEjercicio10()
{
    /*10) Escribir un programa que imprima en la consola todos los múltiplos de 17 o de 29 comprendidos
    entre 1 y 1000.*/

    for (int i = 1; i <= 1000; i++)
    {
        if ((i % 17 == 0) || (i % 29 == 0))
        {
            Console.WriteLine(i);
        }
    }
}

void ejecutarEjercicio11()
{
    /*11) Comprobar el funcionamiento del siguiente fragmento de código, analizar el resultado y contestar
    las preguntas.*/

    Console.WriteLine("10/3 = " + 10 / 3);
    Console.WriteLine("10.0/3 = " + 10.0 / 3);
    Console.WriteLine("10/3.0 = " + 10 / 3.0);
    int a = 10, b = 3;
    Console.WriteLine("Si a y b son variables enteras, si a = 10 y b = 3");
    Console.WriteLine("Entonces a/b = " + a / b);
    double c = 3;
    Console.WriteLine("si c es una variable double, c = 3");
    Console.WriteLine("Entonces a/c = " + a / c);

    /*a) ¿Qué se puede concluir respecto del operador de división “/” ?
    // la division depende de los operadores, si ambos son integer entones el resultado es int, si al menos una variable es double el resultado sera decimal
    b) ¿Cómo funciona el operador + entre un string y un dato numérico ?*/
    // cuando se le asigna + entre un string y un dato numerico primero se resuelve la cuenta y despues se pasa el resultado a string para poder imprimirl
}

void ejecutarEjercicio12()
{
    /*12) Escribir un programa que imprima todos los divisores de un número entero ingresado desde la
    consola.Para obtener el entero desde un string st utilizar int.Parse(st).*/


    Console.WriteLine("Ingrese un numero");
    string st = Console.ReadLine();

    int num = int.Parse(st);

    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine(i);
        }
    }
}

void ejecutarEjercicio13()
{
    /*13) Si a y b son variables enteras, identificar el problema(y la forma de resolverlo) de la siguiente
    expresión.Tip: observar qué pasa cuando b = 0.
    if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);*/

    Console.WriteLine("Ingrese un numero");
    string num1 = Console.ReadLine();
    Console.WriteLine("Ingrese otro numero");
    string num2 = Console.ReadLine();

    int a = int.Parse(num1);
    int b = int.Parse(num2);

    //se cambia & por &&, un solo & verifica ambas condiciones sin importar q la primera ya sea falsa, && verifica la primera, si es falsa no verifica la segunda
    if ((b != 0) && (a / b > 5))
    {
        Console.WriteLine(a / b);
    }
}

void ejecutarEjercicio14()
{
    /*14) Utilizar el operador ternario condicional para establecer el contenido de una variable entera con el
    menor valor de otras dos variables enteras.*/

    Console.WriteLine("Ingrese un numero");
    string num1 = Console.ReadLine();
    Console.WriteLine("Ingrese otro numero");
    string num2 = Console.ReadLine();

    int a = int.Parse(num1);
    int b = int.Parse(num2);

    int menor = (a < b) ? a : b;
    Console.WriteLine("El numero menor es: " + menor);
}

void ejecutarEjercicio15()
{
    //15) ¿Cuál es el problema del código siguiente y cómo se soluciona ?

    /*int i = 0;
    for (int i = 1; i <= 10)
    {
        Console.WriteLine(i++);
    }*/

    //los errores radican de que primero crea 2 variables i lo cual es imposible, y despues la condicion i++ se debe agregar en la estructura del for, no adentro

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
}

void ejecutarEjercicio16()
{
    //16) Analizar el siguiente código. ¿Cuál es la salida por consola?

    int i = 1;
    if (--i == 0) //se realiza el pre-decremento, i ahora vale 0, se cumple
    {
        Console.WriteLine("cero"); //imprime
    }
    if (i++ == 0) // aca hay un post-incremento, primero evalua i y despues incrementa
    {
        Console.WriteLine("cero");
    }
    Console.WriteLine(i); //debido al post incremento, i ahora vale 1

    //la salida por consola es:
    // cero
    // cero
    // 1
}