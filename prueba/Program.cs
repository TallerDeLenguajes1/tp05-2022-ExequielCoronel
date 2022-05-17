// See https://aka.ms/new-console-template for more information
using System;

namespace TallerDeLenguajes
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola mundo";

            Console.WriteLine("Contenido de mi variable cadena actual:"+cadena+"\nIngrese un mensaje: ");
            cadena = Console.ReadLine();
            cadena = cadena.ToLower();
            Console.WriteLine("Nuevo contenido de la cadena: "+cadena);

            int cantidadCar = cadena.Length;
            Console.WriteLine("cantidad de caracteres de la cadena: "+cantidadCar+"\nIngrese un numero entero: ");
            cadena = Console.ReadLine();
            int entero =Convert.ToInt32(cadena);
            Console.Write("Numero ingresado: "+cadena);
        }
    }
}
