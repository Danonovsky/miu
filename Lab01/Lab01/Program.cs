try
{
    var commandLineArgs = Environment.GetCommandLineArgs();
    if (commandLineArgs.Length == 1) throw new ArgumentException("Missing all arguments");
    if(commandLineArgs.Length == 2 && commandLineArgs[1] == "help")
    {
        ShowHelp();
        return;
    }
    if (commandLineArgs.Length == 2) throw new ArgumentException("Missing 2nd and 3rd argument");
    if (commandLineArgs.Length == 3) throw new ArgumentException("Missing 3rd argument");
    var num1 = float.Parse(commandLineArgs[1]);
    var operation = commandLineArgs[2];
    var num2 = float.Parse(commandLineArgs[3]);
    if (num2 == 0 && operation == "/") throw new InvalidOperationException("Cannot divide by 0");
    switch (operation)
    {
        case "+": Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2}"); return;
        case "-": Console.WriteLine($"{num1} {operation} {num2} = {num1 - num2}"); return;
        case "*": Console.WriteLine($"{num1} {operation} {num2} = {num1 * num2}"); return;
        case "/": Console.WriteLine($"{num1} {operation} {num2} = {num1 / num2}"); return;
        default: throw new InvalidOperationException($"Operation '{operation} is not supported");
    }
} 
catch(Exception ex)
{
    Console.WriteLine("ERROR");
    Console.WriteLine(ex.Message);
    Console.WriteLine();
    ShowHelp();
}

static void ShowHelp()
{
    Console.WriteLine("Command line arguments:");
    Console.WriteLine("arg1 arg2 arg3");
    Console.WriteLine("arg1 - first number");
    Console.WriteLine("arg2 - operation ( + - / * )");
    Console.WriteLine("arg3 - second number");
}