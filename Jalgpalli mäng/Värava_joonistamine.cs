using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    public class Värava_joonistamine
    {
        private Game _game;
        private int goalWidth = 6;  //Värava laius (Ширина ворот)
        private int goalHeight = 8; //Värava kõrgus (Высота ворот)
        public Värava_joonistamine(Game game)
        {
            _game = game;
        }
        public void DrawGoals()
        {
            int middleY = _game.Stadium.Height / 2;

            //Kodumeeskonna värav (Ворота домашней команды)
            Draw(0, middleY - goalHeight / 2, ConsoleColor.Yellow);

            //Külalismeeskonna väravad (Ворота гостевой команды)
            Draw(_game.Stadium.Width - goalWidth, middleY - goalHeight / 2, ConsoleColor.Magenta);
        }
        //Väravajoonistamise meetod (Метод для отрисовки ворот)
        public void Draw(int x, int y, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            //Horisontaalsed väravajooned (Горизонтальные линии ворот)
            HorizontalLine upGoal = new HorizontalLine (x + 1, x + goalWidth - 2, y, '-');
            HorizontalLine downGoal = new HorizontalLine (x + 1, x + goalWidth - 2, y + goalHeight - 1, '-');
            //Vertikaalsed väravajooned (Вертикальные линии ворот)
            VerticalLine lefttGoal = new VerticalLine (y + 1, y + goalHeight - 1, x, '+');
            VerticalLine rightGoal = new VerticalLine(y + 1, y + goalHeight - 1, x + goalWidth - 1, '+');
            //Joonistame (Отрисовываем)
            upGoal.Draw();
            downGoal.Draw();
            lefttGoal.Draw();
            rightGoal.Draw();
        }
    } 
}