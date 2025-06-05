do
{
    // See https://aka.ms/new-console-template for more information
    Console.Write("ingrese un numero:");
    var numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.Write("el numero es par");

    }
    else
    {
        Console.Write("el numero es inpar");
    }

} while (true); 