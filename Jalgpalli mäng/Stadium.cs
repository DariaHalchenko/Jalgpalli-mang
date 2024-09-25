using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    //Klass, mis esindab staadionit, kus mäng toimub 
    //Класс, представляющий стадион, на котором проходит игра
    public class Stadium
    {
        //võtab vastu staadioni laiuse ja kõrguse (принимает ширину и высоту стадиона)
        public Stadium(int width, int height)
        {
            Width = width; //staadioni laius (ширина стадиона)
            Height = height; //staadioni kõrgus (высота стадиона)
        }
        //staadioni laius (ширина стадиона)
        public int Width { get; }
        //staadioni kõrgus (высота стадиона)
        public int Height { get; }
        //Meetod kontrolliks, kas koordinaatidega punkt (x, y) on staadioni piiride sees
        //Метод для проверки, находится ли точка с координатами (x, y) внутри границ стадиона
        public bool IsIn(double x, double y)
        {
            //Tagastab true, kui koordinaadid on staadioni piires 
            //Возвращает true, если координаты находятся в пределах стадиона 
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }
    }
}
