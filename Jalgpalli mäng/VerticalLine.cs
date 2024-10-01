using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    // Klass, mis joonistab staadioni ja värava vertikaalsed jooned
    //Класс, который рисует вертикальные линии стадиона и ворот
    public class VerticalLine
    {
        //punktide nimekiri (список точек)
        private  List <Point> point = new List<Point>();
        //Konstruktor, mis loob vertikaalsed jooned
        //Конструктор, который создает вертикальные линии
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                point.Add(p);
            }
        }
        //Liini joonistamise meetod (Метод для отрисовки линии)
        public void Draw()
        {
            foreach (var p in point)
            {
                p.Draw();
            }
        } 
    }
}
