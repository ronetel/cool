using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр7
{
    static class menu
    {
        public static int show(int minstrelochka, int maxstrelochka)
        {
            int pos = minstrelochka;
            ConsoleKeyInfo key;
            do
            { 
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey(true);

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != minstrelochka)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != maxstrelochka + minstrelochka)
                {
                    pos++;
                }
                else if(key.Key == ConsoleKey.Escape )
                {
                    return pos = -1;
                }
            } while (key.Key != ConsoleKey.Enter);
            return pos - minstrelochka; 
        }
    }
}
