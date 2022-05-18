// See https://aka.ms/new-console-template for more information
using System;

string cadena = "Hola Mundo", cadena2="Hello World", cadena3="Esto es una cadena de caracteres";
Console.WriteLine($"Hola Mundo, {cadena}");

Console.WriteLine(cadena.Substring(5)); //Substring(cantidad) quita la cantidad indicada de caracteres desde el inicio de la cadena y devuelve la cadena modificada
Console.WriteLine($"El tamaño de la cadena2={cadena2} es: "+cadena2.Length);
cadena = cadena + cadena3;
Console.WriteLine(cadena);
Console.WriteLine(cadena.Split(" ")[1]);


