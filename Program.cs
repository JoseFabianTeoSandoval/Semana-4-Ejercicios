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
{
    int c = 1;

    while (true)
    {
        if (c % 7 == 0 && c % 11 == 0)
        {
            Console.WriteLine($"El primer número divisible entre 7 y 11 es: {c}");
            break;
        }
        c++;
    }
}
{
    string d;
    do
    {
        Console.Write("Ingresa la contraseña: ");
        d = Console.ReadLine();
    } 
    while (d != "jutiapa");
    Console.WriteLine("Contraseña correcta. Acceso concedido.");
}
{
    Random e = new Random();
    int f = e.Next(1, 101);
    Console.WriteLine("Adivina el número entre 1 y 100:");
    int g;
    do
    {
        Console.Write("Introduce tu intento: ");
        g = int.Parse(Console.ReadLine());
        if (g != f)
        {
            Console.WriteLine("Intenta de nuevo.");
        }
    } while (g != f);
    Console.WriteLine("¡Felicidades! ¡Adivinaste el número!");
}
