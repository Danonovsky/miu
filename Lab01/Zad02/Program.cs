while(true)
{
    ShowMenu();
    var input = Console.ReadKey().KeyChar;
    if (input == '0') return;
    var keys = ReadKeys();
    switch(input)
    {
        case '1': Console.WriteLine($"{keys.Item1} + {keys.Item2} = {keys.Item1 + keys.Item2}"); break;
        case '2': Console.WriteLine($"{keys.Item1} - {keys.Item2} = {keys.Item1 - keys.Item2}"); break;
        case '3': Console.WriteLine($"{keys.Item1} * {keys.Item2} = {keys.Item1 * keys.Item2}"); break;
        case '4': 
            if(keys.Item2 == 0)
            {
                Console.WriteLine("NEVER divide by 0.");
                break;
            }
            Console.WriteLine($"{keys.Item1} / {keys.Item2} = {keys.Item1 / keys.Item2}"); 
            break;
    }
}

static void ShowMenu()
{
    Console.Write(@"
[1] +
[2] -
[3] *
[4] /
[0] Exit
");
}

static Tuple<float,float> ReadKeys()
{
    string? str1, str2;
    float _;
    do
    {
        Console.Write("\nFirst number: ");
        str1 = Console.ReadLine();
    } while (str1 == null || str1.Length == 0 || float.TryParse(str1, out _) is false);
    float n1 = float.Parse(str1);

    do
    {
        Console.Write("\nSecond number: ");
        str2 = Console.ReadLine();
    } while (str2 == null || str2.Length == 0 || float.TryParse(str2, out _) is false);
    float n2 = float.Parse(str2);

    return Tuple.Create(n1, n2);
}