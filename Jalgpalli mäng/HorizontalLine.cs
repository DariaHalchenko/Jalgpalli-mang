using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    //Klass, mis joonistab staadionile ja väravale horisontaalsed jooned 
    //Класс, которыйрисует горизонтальные линии для стадиона и ворот
    public class HorizontalLine
    {
        //punktide nimekiri (список точек)
        private  List <Point> point = new List<Point>();
        //joonistab punktid algsest lõppjooneni ühele joonele 
        //рисует точки от начальной до конечной на одной линии 
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            for (int x = xLeft; x <= xRight; x++)
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
