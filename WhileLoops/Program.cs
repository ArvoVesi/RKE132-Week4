
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; // true / false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Paku suvaline arv, siseta arv ühest kolmeni:");
    
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Palju õnne :DDDDDDDDDDDDD");
        break;
    }
    else
    {
        Console.WriteLine("Paku uuesti :D");
    }
}

Console.WriteLine("Head päeva !");