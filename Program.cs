// See https://aka.ms/new-console-template for more information
Console.Clear();

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("------------------------");
    Console.WriteLine("1 - Addition");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Multiplication");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - Exit");
    Console.WriteLine("------------------------");
    Console.Write("Select an operation: ");
    short operation = short.Parse(Console.ReadLine());

    switch (operation)
    {
        case 1: Addition(); break;
        case 2: Subtraction(); break;
        case 3: Multiplication(); break;
        case 4: Division(); break;
        case 5: System.Environment.Exit(0); break;
        default:
            Console.WriteLine("Incorrect option!");
            Console.WriteLine("Press any key to return to the Menu!");
            Console.ReadLine(); Menu(); break;
    }
}

static void Addition()
{
    Console.Write("First value: ");
    float value1 = float.Parse(Console.ReadLine());

    Console.Write("Second value: ");
    float value2 = float.Parse(Console.ReadLine());

    float result = value1 + value2;
    Console.WriteLine($"The result of the addition is {result}");
    Console.WriteLine("Press any key to return to the Menu!");
    Console.ReadLine();
    Menu();
}

static void Subtraction()
{
    Console.Write("First value: ");
    float value1 = float.Parse(Console.ReadLine());

    Console.Write("Second value: ");
    float value2 = float.Parse(Console.ReadLine());

    float result = value1 - value2;
    Console.WriteLine($"The result of the subtraction is {result}");
    Console.WriteLine("Press any key to return to the Menu!");
    Console.ReadLine();
    Menu();
}

static void Multiplication()
{
    Console.Write("First value: ");
    float value1 = float.Parse(Console.ReadLine());

    Console.Write("Second value: ");
    float value2 = float.Parse(Console.ReadLine());

    float result = value1 * value2;
    Console.WriteLine($"The result of the multiplication is {result}");
    Console.WriteLine("Press any key to return to the Menu!");
    Console.ReadLine();
    Menu();
}

static void Division()
{
    Console.Write("First value: ");
    float value1 = float.Parse(Console.ReadLine());

    Console.Write("Second value: ");
    float value2 = float.Parse(Console.ReadLine());

    float result = value1 / value2;
    Console.WriteLine($"The result of the division is {result}");
    Console.WriteLine("Press any key to return to the Menu!");
    Console.ReadLine();
    Menu();
}