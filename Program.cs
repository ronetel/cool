
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Security.Cryptography;
using пр_4;

    dan d1 = new dan();
    d1.name = "  1.Подойти на паре";
    d1.desc = "  А дальше не работает";
    d1.data = new DateTime(2023, 10, 15);

    dan d2 = new dan();
    d2.name = "  1.Помыть попу";
    d2.desc = "  Сходить в ванну и там нормально уже";
    d2.data = new DateTime(2023, 10, 16);

    dan d3 = new dan();
    d3.name = "  1.Сдать практос по питону";
    d3.desc = "  доделать массивы";
    d3.data = new DateTime(2023, 10, 21);

    dan d4 = new dan();
    d4.name = "  2.Купить подарок сестре";
    d4.desc = "  Набор для рисования";
    d4.data = new DateTime(2023, 10, 21);

    dan d5 = new dan();
    d5.name = "  1.Придти на работу";
    d5.desc = "  к 8 утра быть на смене";
    d5.data = new DateTime(2023, 10, 20);

List < dan > dans = new List<dan>() { d1, d2, d3, d4,d5 };


DateTime date = DateTime.Now;
Console.WriteLine("Дата " + date.ToString());
ConsoleKeyInfo key;
int pos = 1;
int i = 0;
key = Console.ReadKey();
Str(pos, i, date, key, dans);
void Str(int pos, int i, DateTime date, ConsoleKeyInfo key, List<dan> dans)
{

do
{
        key = Console.ReadKey();    
        Console.SetCursorPosition(0, pos);
        Console.WriteLine("  ");
        if (key.Key == ConsoleKey.UpArrow && pos != 1)
        { pos--; }
        else if (key.Key == ConsoleKey.DownArrow && pos != 4)
        { pos++; }
        else if (key.Key == ConsoleKey.RightArrow)
        {
            Console.Clear();
            date = date.AddDays(1);
            Console.WriteLine("Дата " + date.ToString());
        }
        else if (key.Key == ConsoleKey.LeftArrow)
        {
            Console.Clear();
            date = date.AddDays(-1);
            Console.WriteLine("Дата " + date.ToString());
        }

        if (i != dans.Count)
        {
            for (; i < dans.Count; i++)
            {
                if (dans[i].data.Date == date.Date)
                    Console.Write("  " + dans[i].name);
                
            }
        }
        Console.SetCursorPosition(0, pos);
        Console.WriteLine("->");
        if(key.Key== ConsoleKey.Enter)
        { 
        
        Opis(key, d1);
            continue;
        }
        
    
} while (key.Key != ConsoleKey.Escape);
}


 void Opis(ConsoleKeyInfo key, dan d1)
{
        while(true)
        {  
           
            Console.Clear();
            Console.WriteLine(d1.name);
            Console.WriteLine(d1.desc);
            Console.WriteLine(d1.data);
            Console.ReadKey();
      
            break;
        }

    
}

