// See https://aka.ms/new-console-template for more information
using System;

string cadena = "Hola Mundo", cadena2="Hello World", cadena3="Esto es una cadena de caracteres";
Console.WriteLine($"Hola Mundo, {cadena}");

Console.WriteLine(cadena.Substring(5)); //Substring(cantidad) quita la cantidad indicada de caracteres desde el inicio de la cadena y devuelve la cadena modificada
Console.WriteLine($"El tamaño de la cadena2={cadena2} es: "+cadena2.Length);
cadena = cadena + cadena3;
Console.WriteLine(cadena);
Console.WriteLine(cadena.Split(" ")[1]);
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
            Console.WriteLine("\n"+$"La suma entre {num1} y {num2} es igual a: {num1+num2}"+"\n");
            break;
        case 2:
            Console.WriteLine("\n"+$"La resta entre {num1} y {num2} es igual a: {num1-num2}"+"\n");
            break;
        case 3:
            Console.WriteLine("\n"+$"La division entre{num1} y {num2} es igual a: {num1/num2}"+"\n");
            break;
        case 4:
            Console.WriteLine("\n"+$"El producto entre{num1} y {num2} es igual a: {num1*num2}"+"\n");
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

foreach (char item in cadena2)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Escriba la palabra a buscar en la cadena: {cadena}: ");
cadena2=Console.ReadLine();
if(BuscarPalabra(cadena, cadena2)){
    Console.WriteLine("La palabra se encuentra en la oracion!\n");
} else {
    Console.WriteLine("La palabra no se encuentra en la oracion!\n");
}
Console.WriteLine($"cadena3 tal y como fue guardada: {cadena3}");
cadena3=cadena3.ToLower();
Console.WriteLine($"cadena3 luego de aplicarle ToLower: {cadena3}");
cadena3=cadena3.ToUpper();
Console.WriteLine($"cadena3 luego de aplicarle ToUpper: {cadena3} \n\n Ingrese una nueva cadena: ");

Console.WriteLine("Por favor ingrese un listado de nombres separados por \".\": ");
string cadenaPrueba = Console.ReadLine();
string [] listado = cadenaPrueba.Split(".");
Console.WriteLine("\n\tListado de nombres: \n");
foreach (string nombre in listado)
{
    Console.WriteLine(nombre);
}
Console.WriteLine("\nIngrese una ecuacion simple a resolver: ");
string ecuacionSimple = Console.ReadLine();
char operacionC='0';
if(ecuacionSimple.IndexOf('+')!=-1)
{
    operacionC='+';
} else {
    if(ecuacionSimple.IndexOf('-')!=-1)
    {
        operacionC='-';
    } else {
        if(ecuacionSimple.IndexOf('/')!=-1)
        {
            operacionC='/';
        } else {
            if (ecuacionSimple.IndexOf('*')!=1)
            {
                operacionC='*';
            }
        }
    }
}

string [] operandos = ecuacionSimple.Split(operacionC);
int operando1=Convert.ToInt32(operandos[0]), operando2=Convert.ToInt32(operandos[1]);
switch (operacionC)
{
    case '+':
        Console.WriteLine($"La suma entre {operando1} y {operando2} es {operando1+operando2}");
        break;
    case '-':
        Console.WriteLine($"La resta entre {operando1} y {operando2} es {operando1-operando2}");
        break;
    case '*':
        Console.WriteLine($"El producto entre {operando1} y {operando2} es {operando1*operando2}");
        break;
    case '/':
        Console.WriteLine($"El cociente entre {operando1} y {operando2} es {operando1/operando2}");
        break;
    default:
        Console.WriteLine("No se reconoce la operacion indicada!");
        break;
}


bool BuscarPalabra(string cadena,string buscar)
{
    string[] busqueda = cadena.Split(" ");
    foreach (string clave in busqueda)
    {
        if(clave == buscar)
        {
            return true;
        }
    }
    return false;
}


