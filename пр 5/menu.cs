﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр_5
{
    internal class menu
    {
        public static int show(int minstrelochka, int maxstrelochka)
        {
            
            int pos = 3;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine ("  ");
                if (key.Key == ConsoleKey.UpArrow && pos != minstrelochka)
                {

                    pos--;
                                }
                else if (key.Key == ConsoleKey.DownArrow && pos != maxstrelochka)
                {
                    pos++;
                }
            } while (key.Key != ConsoleKey.Enter);
            return pos;

        }
    }
}