/* 
EJ 1: Consultar en la documentación de Microsoft y responder cuál es la diferencia entre los métodos
WriteLine() y Write() de la clase System.Console ¿Cómo funciona el método ReadKey() de
la misma clase? Escribir un programa que imprima en la consola la frase “Hola Mundo”
haciendo una pausa entre palabra y palabra esperando a que el usuario presione una tecla para
continuar Tip: usar los métodos ReadKey() y Write() de la clase System.Console.

Console.Write("Hola");
Console.ReadKey(true);
Console.Write(" mundo!");
*/
/*
EJ 2: Investigar por las secuencias de escape \n, \t , \" y \\. Escribir un programa que las utilice
para imprimir distintos mensajes en la consola.

Console.Write("Hola\n");
Console.Write("Hola\t");
Console.Write("Hola\"");
Console.Write("Hola\\");
*/
/*
EJ 3:El carácter @ delante de un string desactiva los códigos de escape. Probar el siguiente
fragmento de código, eliminar el carácter @ y utilizar las secuencias de escape necesarias para
que el programa siga funcionando de igual manera

string st = "c:\\windows\\system";
Console.WriteLine(st);
*/
/*
EJ 4: Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un
saludo personalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una
línea en blanco. Para ingresar un string desde el teclado utilizar Console.ReadLine()

Console.WriteLine("Ingrese su nombre: ");
string nombre= Console.ReadLine();
Console.WriteLine("Hola "+ nombre + "!");
*/
/*
EJ 5: Idem. al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el
nombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María”
debe imprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso,
debe imprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha
ingresado una línea vacía.
a) utilizando if ... else if
b) utilizando switch
/*
A-
Console.WriteLine("Ingrese su nombre: ");
string nombre= Console.ReadLine();
if(nombre== "Juan") 
    Console.WriteLine("¡Hola amigo!");
else if (nombre == "María")
    Console.WriteLine("Buen día señora");
else if (nombre == "Alberto")
    Console.WriteLine("Hola Alberto");
else if (nombre=="")
    Console.WriteLine("¡Buen día mundo!");
else 
    Console.WriteLine("Buen día "+ nombre);


B-
*/
/*
Console.WriteLine("Ingrese su nombre: ");
string nombre= Console.ReadLine();
switch(nombre)
{
    case "Juan":
        Console.WriteLine("¡Hola amigo!");
        break;
    case "María":
        Console.WriteLine("Buen día señora");
        break;
    case "Alberto":
        Console.WriteLine("Hola Alberto");
        break;
    case "":
        Console.WriteLine("¡Buen día mundo!");
        break;
    default:
        Console.WriteLine("Buen día "+ nombre);
        break;
}
*/
/*
EJ 6: Utilizar Console.ReadLine() para leer líneas de texto (secuencia de caracteres que finaliza al
presionar <ENTER>) por la consola. Por cada línea leída se debe imprimir la cantidad de
caracteres de la misma. El programa termina al ingresar la cadena vacía. (si st es una variable
de tipo string, entonces st.Length devuelve la cantidad de caracteres del string).

string cadena;
Console.WriteLine("Ingrese cadenas seguidas de enter:");
cadena= Console.ReadLine();
while (cadena != ""){
    Console.WriteLine("Caracteres: "+ cadena.Length);
    cadena= Console.ReadLine();
}
*/
/*
EJ 7: Qué hace la instrucción Console.WriteLine("100".Length);

Console.WriteLine("100".Length);
*/
/*
EJ 8: Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:
Console.WriteLine(st=Console.ReadLine());?

string st;
Console.WriteLine(st=Console.ReadLine());
*/