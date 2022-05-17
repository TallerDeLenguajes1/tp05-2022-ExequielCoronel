// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Ingrese un numero a Invertir: ");
string numero1=Console.ReadLine();
int numeroInvertido=InvertirNum(numero1);
Console.WriteLine("El numero Invertido es: "+numeroInvertido);

 int InvertirNum(string numero)
{
    char[] arreNum = numero.ToCharArray();
    Array.Reverse(arreNum);
    numero=new String(arreNum);
    int invertido=Convert.ToInt32(numero);
    return invertido;
}

