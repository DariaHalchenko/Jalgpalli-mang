using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    public class Staadioni_joonis
    {
        private Game _game;

        public Staadioni_joonis(Game game)
        {
            _game = game;
        }

        // Метод для отрисовки всего игрового поля
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            HorizontalLine upLine = new HorizontalLine(0, _game.Stadium.Width - 1, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, _game.Stadium.Width - 1, _game.Stadium.Height - 1, '_');
            VerticalLine leftLine = new VerticalLine(0, _game.Stadium.Height - 1, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, _game.Stadium.Height - 1, _game.Stadium.Width - 1, '|');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
        }
    } 
}