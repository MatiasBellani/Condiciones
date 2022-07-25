// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();

// Ejemplo de condicional IF

/*

Console.WriteLine(" Por favor ingresar su edad");

int edad = int.Parse(Console.ReadLine()); // Necesito ponerle un PARCE para convertir lo que viene como un string desde el read line

Console.WriteLine(" la edad que ingresaste es " + edad);

bool EdadDelUsuario = edad < 18;

if ( EdadDelUsuario)

{

    Console.WriteLine(" Usted es menor de edad");
}
else
{
    {

        Console.WriteLine(" Usted es mayor de edad");
    }
}

Console.ReadKey();

*/

// if-elseif- else

/*

Console.WriteLine(" Ingrese la edad ");

int edad = int.Parse(Console.ReadLine());

Console.WriteLine( " La edad que ingresaste es  " + edad );

bool EdadDelUsuario = edad > 18;

if (edad > 18 && edad < 150)
{

    Console.WriteLine(" Usted ya termino la escuela ");


}
else if (edad > 10 && edad < 18)
{

    Console.WriteLine(" Usted va a la secundaria");
}

else if (edad > 6 && edad < 10)
{
    Console.WriteLine(" Usted va a la primaria");


}

else if (edad < 0 || edad > 150) 
{

    Console.WriteLine(" Usted ingreso una edad invalidad");
}
else
{

    Console.WriteLine(" Usted va al jardín");
}
*/

// Aca vamos a trabajar con el swicht vamos a hacer a una calculadora

Console.WriteLine(" Por favor ingresa un numero solamente entero");

int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine(" Por favor ingresa un segundo número entero");

int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine(" Ahora deberas elegir la opción que operación quieres realizar");

Console.WriteLine("1- Suma");
Console.WriteLine("2- Resta");
Console.WriteLine("3- Multiplicación");
Console.WriteLine("4- División");

string  opcionelegida = Console.ReadLine();
double resultado = 0;

switch (opcionelegida)

    { 
    case "1":

        Console.WriteLine(" Sumando....");
        resultado = numero1 + numero2;
       
        break;

    case "2":

        Console.WriteLine(" Restando....");
        resultado = numero1 - numero2;
        
        break;

    case "3":

        Console.WriteLine(" Multiplicando....");
        resultado = numero1 * numero2;
        
        break;

    case "4" when numero2 != 0:

        Console.WriteLine(" Dividiendo....");
        resultado = numero1 / numero2;
        
        break;

default:
        Console.WriteLine(" Ingrese una opción no valida");
        break;
}


Console.WriteLine(" El resultado es  " + resultado);



