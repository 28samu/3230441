do
{
    Console.WriteLine("ingrese primer numero entero:");
    var N1 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese segundo numero entero");
    var N2 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese tercer numero entero");
    var N3 = int.Parse(Console.ReadLine());

    if (N1 > N2 & N2 > N3)
    {
        Console.WriteLine($"el numero mayor es: {N1}");
    }
    else if (N1 > N3 & N3 > N2)
    {
        Console.WriteLine($"el numero mayor es: {N1}");
    }
    else if (N2 > N1 & N1 > N3)
    {
        Console.WriteLine($"el numero mayor es: {N2}");
    }
    else if (N2 > N3 & N3 > N1)
    {
        Console.WriteLine($"el numero mayor es: {N2}");
    }
    else if (N3 > N1 & N1 > N3)
    {
        Console.WriteLine($"el numero mayor es: {N3}");
    }
    else
    {
        Console.WriteLine($"el numero mayor es: {N3}");
    }




} while (true);







Console.WriteLine("Hello, World!");

