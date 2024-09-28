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
        private int goalWidth = 6;  // Ширина ворот
        private int goalHeight = 4; // Высота ворот
        public Värava_joonistamine(Game game)
        {
            _game = game;
        }
        public void DrawGoals()
        {
            int middleY = _game.Stadium.Height / 2;

            // Ворота домашней команды
            Draw(0, middleY - goalHeight / 2);

            // Ворота гостевой команды
            Draw(_game.Stadium.Width - goalWidth, middleY - goalHeight / 2);
        }
        // Метод для отрисовки ворот
        public void Draw(int x, int y)
        {
            // Горизонтальные линии ворот
            HorizontalLine upGoal = new HorizontalLine (x + 1, x + goalWidth - 2, y, '-');
            HorizontalLine downGoal = new HorizontalLine (x + 1, x + goalWidth - 2, y, '-');
            VerticalLine rightGoal = new VerticalLine(y, y + goalHeight - 1, x, '+');
            VerticalLine lefttGoal = new VerticalLine (y, y + goalWidth - 1, x + goalHeight - 1, '+');
    
            upGoal.Draw();
            downGoal.Draw();
            rightGoal.Draw();
            lefttGoal.Draw();
        }
    } 
}