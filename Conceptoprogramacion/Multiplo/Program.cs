do
{
    Console.WriteLine("ingrese primer numero entero:");
    var N1 = (Console.ReadLine());

    if (int.TryParse(N1, out int N1Int))
    {
        Console.WriteLine("ingrese segundo numero entero");
        var N2 = (Console.ReadLine());
        if (int.TryParse(N2, out int N2Int))
        {
            if (N1Int % N2Int == 0)
            {
                Console.WriteLine($" N1 es multiplo {N2}:");
            }
            else
            {
                Console.WriteLine($" N1 no es multiplo de {N2} :");
            }
        }
        else
        {
            Console.WriteLine(" debes ingresar un numero entero");
        }
        
    }
    else
    {
        Console.WriteLine(" debes ingresar un numero entero");
    }







} while (true);


