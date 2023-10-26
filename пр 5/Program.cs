using пр_5;
using System.IO;

int price = 0;
string vibor = "";
ConsoleKeyInfo key; 
do
{
    Console.Clear();
    opis m = new opis();
    Console.WriteLine(" Добро пожаловать во вкусно и точка!!!");
    Console.WriteLine(" Сделайте свой заказ");
    Console.WriteLine("---------------------------");
    foreach (var item in m.mein)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("Цена: " + price);
    Console.WriteLine("Заказ:" + vibor);
    int pos = menu.show(3, 8);
    if (pos == 3)
    {
        Console.Clear();
        Console.WriteLine(" Для выбора пункта 2 раза нажмите Enter, а для выхода нажмите Enter & Escape");
        Console.WriteLine(" Сделайте свой заказ");
        Console.WriteLine("---------------------------");
        foreach (var item in m.burg)
        {
            Console.WriteLine( item.name + " " + item.price);
        }
        pos = menu.show(3, 5);
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Escape)
        {
            continue;
        }
        vibor += m.burg[pos - 3].name;
        price += m.burg[pos - 3].price;
        Console.Clear();
        continue;
    }
    else if (pos == 4)
    {
        Console.Clear();
        Console.WriteLine(" Для выбора пункта 2 раза нажмите Enter, а для выхода нажмите Enter & Escape"); ;
        Console.WriteLine(" Сделайте свой заказ");
        Console.WriteLine("---------------------------");
        foreach (var item in m.drink)
        {
            Console.WriteLine(item.name + " " + item.price);
        }
        pos = menu.show(3, 5);
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Escape)
        {
            continue;
        }
        vibor += m.drink[pos - 3].name;
        price += m.drink[pos - 3].price;
        Console.Clear();
        continue;
    }
    else if (pos == 5)
    {
        Console.Clear();
        Console.WriteLine(" Для выбора пункта 2 раза нажмите Enter, а для выхода нажмите Enter & Escape");
        Console.WriteLine(" Сделайте свой заказ");
        Console.WriteLine("---------------------------");
        foreach (var item in m.cneck)
        {
            Console.WriteLine(item.name + " " + item.price);

        }
        pos = menu.show(3, 5);
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Escape)
        {
            continue;
        }
        vibor += m.cneck[pos - 3].name;
        price += m.cneck[pos - 3].price;
        Console.Clear();
        continue;
    }
    else if (pos == 6)
    {
        Console.Clear();
        Console.WriteLine(" Для выбора пункта 2 раза нажмите Enter, а для выхода нажмите Enter & Escape");
        Console.WriteLine(" Сделайте свой заказ");
        Console.WriteLine("---------------------------");
        foreach (var item in m.des)
        {
            Console.WriteLine(item.name + " " + item.price);

        }
        pos = menu.show(3, 5);
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Escape)
        {
            continue;
        }
        vibor += m.des[pos - 3].name;
        price += m.des[pos - 3].price;
        Console.Clear();
        continue;
    }
    else if (pos == 7)
    {
        Console.Clear();
        Console.WriteLine(" Для выбора пункта 2 раза нажмите Enter, а для выхода нажмите Enter & Escape");
        Console.WriteLine(" Сделайте свой заказ");
        Console.WriteLine("---------------------------");
        foreach (var item in m.sal)
        {
            Console.WriteLine(item.name + " " + item.price);
        }
        pos = menu.show(3, 5);
        key = Console.ReadKey();    
        vibor += m.sal[pos - 3].name;
        price += m.sal[pos - 3].price;
        Console.Clear();
        continue;
    }
    else if (pos == 8)
    {
        DateTime data = DateTime.Now;
        Console.Clear();
        Console.WriteLine("Спасибо что постели наше предприятие, ваш чек сохранен в папку проекта\n Если хотите новый заказ нажмите Escape");
        File.AppendAllText("чек.txt", "\n Чек от: " + data + "\nЗаказ: " + vibor + "\nСтоимость: " + price);
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.Escape)
        {
            price = 0;
            vibor = "";
            continue;
        }
        else
        { break; }
    }
} while (true);
