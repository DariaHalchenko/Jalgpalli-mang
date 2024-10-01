using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    //Klass, mis kirjeldab ekraanil olevat punkti
    //Класс, который описывает точку на экране
    public class Point
    {
        public int x { get; }
        public int y { get; }
        public char symbol { get; }

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }
        //Meetod ekraanile punktide kuvamiseks
        //Метод для отображения точек на экране
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}