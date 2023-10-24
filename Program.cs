
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Timers;
using пр_4;

dan d1 = new dan();
d1.name = "  Подойти на паре";
d1.desc = " спросить как сделать все в разных методах";
d1.data = new DateTime(2023, 10, 15);

dan d2 = new dan();
d2.name = "  Помыть попу";
d2.desc = " Сходить в ванну и там нормально уже";
d2.data = new DateTime(2023, 10, 16);

dan d3 = new dan();
d3.name = "  Сдать практос по питону";
d3.desc = "доделать массивы";
d3.data = new DateTime(2023, 10, 21);

dan d4 = new dan();
d4.name = "  Купить подарок сестре";
d4.desc = " Набор для рисования";
d4.data = new DateTime(2023, 10, 18);

dan d5 = new dan();
d5.name = "  Придти на работу";
d5.desc = "к 8 утра быть на смене";
d5.data = new DateTime(2023, 10, 20);

List<dan> dans = new List<dan>() { d1, d2, d3, d4, d5 };
DateTime date = new DateTime(2023, 10, 17);

while (true)
{
    Console.Clear();
    Console.WriteLine("Дата " + date.ToShortDateString());
    ConsoleKeyInfo key;
    int pos = 1;
    int i = 0;
    key = Console.ReadKey();

    Str(pos, date, key, dans);
    if (date == d1.data)
    {
        Wer();
    }
    else if (date == d2.data)
    {
        Wer();
    }
    else if (date == d3.data && pos == 1)
    {
        Wer();
    }
    else if (pos == 1 && date == d4.data)
    {
        Wer();
    }
    else if (date == d5.data)
    {
        Wer();

    }

}

int Str(int pos, DateTime date, ConsoleKeyInfo key, List<dan> dans)
{
    do
    {
        Console.SetCursorPosition(0, pos);
        key = Console.ReadKey();
        Console.WriteLine("  ");
        if (key.Key == ConsoleKey.UpArrow && pos != 1)
        { pos--; }
        else if (key.Key == ConsoleKey.DownArrow && pos != 4)
        { pos++; }
        else if (key.Key == ConsoleKey.RightArrow)
        { Opis(1); }
        else if (key.Key == ConsoleKey.LeftArrow)
        { Opis(-1); }
        Console.SetCursorPosition(0, pos);
        Console.WriteLine("->");
    } while (key.Key != ConsoleKey.Enter);
    return pos;
}
void Opis(int amountDays)
{
    Console.Clear();
    date = date.AddDays(amountDays);
    Console.WriteLine("Дата " + date.ToShortDateString());
    for (int i = 0; i < dans.Count; i++)
    {
        if (dans[i].data.Date == date.Date)
            Console.Write("  " + dans[i].name + "\n");
    }
}
void Wer()
{
    Console.Clear();
    for (int i = 0; i < dans.Count; i++)
    {
        if (dans[i].data.Date == date.Date)
        {
            Console.Clear();
            Console.WriteLine(dans[i].name);
            Console.WriteLine("--------------------");
            Console.WriteLine("Описание: " + dans[i].desc);
            Console.WriteLine("Дата: " + dans[i].data);
            Console.ReadKey();
        }
    }

}