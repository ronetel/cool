using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр_5
{
    internal class opis
    {
       public List<string> mein = new List<string>()
        {
            "  Бургеры", "  Напитки", "  Снеки", "  Пирожки", "  Салаты", "  Конец заказа"
        };
        public List<podpunkt> burg = new List<podpunkt>()
         
        {
           new podpunkt("  Гамбургер", 59),
           new podpunkt("  Чизбургер", 69),
           new podpunkt("  Чикенбургер", 69)
        };  
        public List<podpunkt> drink = new List<podpunkt>()
        {
            new podpunkt("  Кола", 89),
            new podpunkt("  Фанта", 89),
            new podpunkt("  Спрайт", 89),
        };
        public List<podpunkt> cneck = new List<podpunkt>()
        {
            new podpunkt("  Нагетсы", 99),
            new podpunkt("  Стрипсы", 89),
            new podpunkt("  Крылышки", 109),
        };
        public List<podpunkt> des = new List<podpunkt>()
        {
            new podpunkt("  Вишня", 89),
            new podpunkt("  Клубника и персик", 175),
            new podpunkt("  Норвежские ягоды", 65),
        };
        public List<podpunkt> sal = new List<podpunkt>()
        {
            new podpunkt("  Цезарь ", 129),
            new podpunkt("  Цезарь с креветками ", 129),
            new podpunkt("  Овощной ", 129),
        };
    }
}

