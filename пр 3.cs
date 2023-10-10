using System;

Console.WriteLine("Добро пожаловать в пианино!!!");
Console.WriteLine("Выберите октаву - F6 или F7");
ConsoleKeyInfo chose = Console.ReadKey(true);

voes(chose);
static int[] oktava1(ConsoleKeyInfo chose)
{
    int[] oktavaa1 = new int[12];
    if (chose.Modifiers.HasFlag(ConsoleModifiers.Control) && chose.Key == ConsoleKey.F6)
    {
        Console.Write("6 октава");
        Console.WriteLine();
        oktavaa1 = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };

    }
    if (chose.Modifiers.HasFlag(ConsoleModifiers.Control) && chose.Key == ConsoleKey.F7)
    {
        Console.Write("7 октава ");
        Console.WriteLine();
        oktavaa1 = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };

    }
    return oktavaa1;
}
static void voes(ConsoleKeyInfo chose)
{
    int[] oktavaa1 = oktava1(chose);
    while (true)
    {
        if(chose.Key == ConsoleKey.Q)
        { Console.Beep(oktavaa1[0], 300); }
        else if(chose.Key == ConsoleKey.W)
        { Console.Beep(oktavaa1[1], 300); }
        else if(chose.Key == ConsoleKey.E)
        { Console.Beep(oktavaa1[2], 300); }
        else if(chose.Key == ConsoleKey.R)
        { Console.Beep(oktavaa1[3], 300); }
        else if(chose.Key == ConsoleKey.T)
        { Console.Beep(oktavaa1[4], 300); }
        else if(chose.Key == ConsoleKey.Y)
        { Console.Beep(oktavaa1[5], 300); }
        else if(chose.Key == ConsoleKey.U)
        { Console.Beep(oktavaa1[6], 300); }
        else if(chose.Key == ConsoleKey.I)
        { Console.Beep(oktavaa1[7], 300); }
        else if(chose.Key == ConsoleKey.O)
        { Console.Beep(oktavaa1[8], 300); }
        else if(chose.Key == ConsoleKey.P)
        { Console.Beep(oktavaa1[9], 300); }
        else if(chose.Key == ConsoleKey.A)
        { Console.Beep(oktavaa1[10], 300); }
        else if(chose.Key == ConsoleKey.S)
        { Console.Beep(oktavaa1[11], 300); }
        else
            oktavaa1 = oktava1(chose);
        chose = Console.ReadKey(true);
    }
}