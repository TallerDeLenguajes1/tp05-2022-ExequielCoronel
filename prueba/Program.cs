// See https://aka.ms/new-console-template for more information
using System;
double num,num1,num2;

Console.WriteLine("Ingrese un numero: ");
num=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n|"+num+"| = "+Math.Abs(num));
Console.WriteLine("\nEl cuadrado de "+num+" es: "+Math.Pow(num,2));
Console.WriteLine("\nLa raiz cuadrada de "+num+"es: "+Math.Sqrt(num));
Console.WriteLine("\nsen("+num+") = "+Math.Sin(num));
Console.WriteLine("\nCos("+num+") = "+Math.Cos(num));
Console.WriteLine("La parte entera de "+num+" es: "+Math.Truncate(num));
Console.WriteLine("Ingrese un numero: ");
num1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese otro numero: ");
num2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("El maximo entre "+num1+" y "+num2+" es: "+Math.Max(num1,num2)+"\n");
Console.WriteLine("El minimo entre "+num1+" y "+num2+" es: "+Math.Min(num1,num2)+"\n");