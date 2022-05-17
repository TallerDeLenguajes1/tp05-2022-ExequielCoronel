// See https://aka.ms/new-console-template for more information
using System;
int marca=0, operacion=0;
double num1=0, num2=0, resultado=0;
do{
    Console.WriteLine("\tBienvenido a Calculadora!\n\nQue operacion desea realizar?\n1=Suma\n2=Resta\n3=Division\n4=Producto");
    operacion=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese un numero: ");
    num1=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese otro numero: ");
    num2=Convert.ToDouble(Console.ReadLine());
    switch (operacion)
    {
        case 1:
            Console.WriteLine("\n"+num1+"+"+num2+"="+Sumar(num1,num2)+"\n");
            break;
        case 2:
            Console.WriteLine("\n"+num1+"-"+num2+"="+Restar(num1,num2)+"\n");
            break;
        case 3:
            Console.WriteLine("\n"+num1+"/"+num2+"="+Dividir(num1,num2)+"\n");
            break;
        case 4:
            Console.WriteLine("\n"+num1+"*"+num2+"="+Multiplicar(num1,num2)+"\n");
            break;
        default:
            Console.WriteLine("\nOperacion invalida!\n");
            break;
    }
    
    do{
        Console.WriteLine("\nDesea ejecutar de nuevo Calculadora?: 1=Si, 0=No");
        marca=Convert.ToInt32(Console.ReadLine());
    }while(marca!=1 && marca!=0);
}while(marca==1);

double Sumar(double a, double b)
{
    return a+b;
}

double Restar(double a, double b)
{
    return a-b;
}

double Multiplicar(double a, double b)
{
    return a*b;
}

double Dividir(double a, double b)
{
    return a/b;
}