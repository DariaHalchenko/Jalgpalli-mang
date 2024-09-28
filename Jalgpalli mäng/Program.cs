using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            

            var stadiumWidth = 70; // Ширина стадиона
            var stadiumHeight = 20; // Высота стадиона

            var stadium = new Stadium(stadiumWidth, stadiumHeight);
            var game = new Game(new Team("Meeskond1"), new Team("Meeskond2"), stadium);

            var stadiumDrawing = new Staadioni_joonis(game);
            var goalDrawing = new Värava_joonistamine(game);

            stadiumDrawing.Draw();
            goalDrawing.DrawGoals();

            Thread.Sleep(50000);
        }
    }
}
