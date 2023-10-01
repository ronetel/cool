namespace пр_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("   Выбор действия : ");
                Console.WriteLine("1. Игра Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Выход из программы");
                int vibor = Convert.ToInt32(Console.ReadLine());

                if (vibor == 1) { Igra(); }
                if (vibor == 2){ tabl();}
                if(vibor == 3) { chi(); }
                if(vibor == 4) { break; }
            }
        }
        static void Igra()
        {
            Random rnd = new Random();
            int i = rnd.Next(100);
            while (i > 0)
            {
                Console.WriteLine("Введите предпологаемое число: ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == i)
                {
                    Console.WriteLine("Поздравляю, вы угадали!!!");
                    break;
                }

                if (a > i)
                { Console.WriteLine("Загаданное число меньше"); }

                if (a < i)
                { Console.WriteLine("Загаданное число больше"); }

            }
        }

                static void tabl()
                {
                    int[,] tab = new int[11, 11];

                    for (int a = 1; a < 11; a++)
                    {
                        for (int b = 1; b < 11; b++)
                        {
                            tab[a, b] = a * b;
                            Console.Write (tab[a, b] + "\t");
                        }
                            Console.WriteLine();
                    }

                }

        static void chi()
        {
            Console.WriteLine(" Введите число");
            int vibor = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= vibor; i++)
            {
                if (vibor % i == 0)
                {
                    Console.Write(" " + i);
                    Console.WriteLine();
                }
            }
        }

    }      
}   