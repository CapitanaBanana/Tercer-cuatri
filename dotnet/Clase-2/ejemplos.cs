﻿/*object obj = 7.3;
Console.WriteLine(obj.GetType());

obj= "casa";
Console.WriteLine(obj.GetType());

obj=4;
Console.WriteLine(obj.GetType());
Console.WriteLine((int)obj+1);//hago unboxing metiendo el int, sino da error

obj= 1+2.3;
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

obj = "CAS" + 'A'; //junta las strings
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

obj = "AREA" + 5 + 1; //junta las strings, imprime area 51
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

obj = 5+1+ "AREA"; //junta las strings, imprime 6 area
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

obj = 52 + 'e'; //int + char suma valores ascii
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);
*/
char c1='A';
char c2='A';
Console.WriteLine(c1==c2);
object c3='A';
object c4='A';
Console.WriteLine((char)c3==(char)c4);/*no puedo comparar de una lo que esta en heap porque podria tener problemas de ejecucion
 aunque puedo usar equals. Una opcion mejor es pedir el tipo de las vars*/
object o1='A';
object o2=o1;
Console.WriteLine(o1==o2);