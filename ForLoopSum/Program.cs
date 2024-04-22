int sum = 0;

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"i võrdub: {i}");
    Console.WriteLine($"Praegune summa: {sum}");
    sum = sum + i;
}

Console.WriteLine($"Lõpp summa: {sum}");