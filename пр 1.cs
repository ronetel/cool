using System.Numerics;

while (true)
{
    Console.WriteLine("Выберите операцию");
    Console.WriteLine("1.Сложение ");
    Console.WriteLine("2.Вычитание");
    Console.WriteLine("3.Умножение");
    Console.WriteLine("4.Деление");
    Console.WriteLine("5.Найти квадратный корень");
    Console.WriteLine("6.Найти 1 процент из числа");
    Console.WriteLine("7.Факториал");
    Console.WriteLine("8.Возвести в степень N первое число");
    Console.WriteLine("9.Выйти из программы");
    Console.WriteLine("Введите номер операции:");
    int text = int.Parse(Console.ReadLine());


    double num = 0;
    
    

        if (text == 1)
        {
            Console.WriteLine("Введите первое число");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double y = int.Parse(Console.ReadLine());
            num = x + y;
            Console.WriteLine("Ваше число " + num);
            
        }

        if (text == 2)
        {
            Console.WriteLine("Введите первое число");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double y = int.Parse(Console.ReadLine());
            num = x - y;
            Console.WriteLine("Ваше число " + num);
          
        }

        if (text==3)
        {
            Console.WriteLine("Введите первое число");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double y = int.Parse(Console.ReadLine());
            num = x * y;
            Console.WriteLine("Ваше число " + num);
           
        }

        if (text == 4)
        {
            Console.WriteLine("Введите первое число");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double y = int.Parse(Console.ReadLine());
            num = x/y;
            Console.WriteLine("Ваше число " + num);
            
        }

        if (text == 5)
        {
            Console.WriteLine("Введите число");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваше число " + Math.Sqrt(x));
            
        }

        if (text == 6)
        {
            Console.WriteLine("Введите число");
            double x = int.Parse(Console.ReadLine());
            num = x / 100;
            Console.WriteLine("Ваше число " + num);
           
        }


        if (text == 7)
        {
            Console.WriteLine("Введите число");
            int x = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial = factorial * i;
            }


            Console.WriteLine("Факториал равен " + factorial);
           
        }

        if (text == 8)
        {
            Console.WriteLine("Введите число");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень");
            double y = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваше число " + Math.Pow(x,y));
            
        }

    if (text == 9)
    {
        Console.WriteLine("Завершение программы");
        break;
    }


}
