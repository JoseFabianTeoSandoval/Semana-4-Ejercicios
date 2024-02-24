{
    int x = 2;
    while (x <= 10)
    {
        Console.WriteLine("{0}", x);
        x = x + 2;
    }
    Console.ReadKey();
}
{
    int y = 0;
    int z = 0;
    while (y < 10)
    {
        y++;
        z = z + y;
    }
    Console.WriteLine($"el resultado de la suma de los numeros 1-10: {z}");
}
{
    int a = 0;
    int b = 0;
    do
    {
        Console.WriteLine("Ingrese un numero entero positivo");
        a = Convert.ToInt32(Console.ReadLine());
        b = b + a;
    }
    while (a > 0);
    Console.WriteLine($"La suma de los numeros positivos es: {b}");
    Console.ReadKey();
}
