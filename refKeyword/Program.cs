

int b = 10;

x(ref b);

void x(ref int b)
{
    b += b;
    Console.WriteLine(b);
}

Console.WriteLine(b);


