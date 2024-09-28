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
            HorizontalLine upLine = new HorizontalLine(0, _game.Stadium.Width - 1, 0, '_');
            HorizontalLine downLine = new HorizontalLine(0, _game.Stadium.Width - 1, _game.Stadium.Height - 1, '_');
            VerticalLine leftLine = new VerticalLine(0, _game.Stadium.Height - 1, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, _game.Stadium.Width - 1, _game.Stadium.Height - 1, '|');

            leftLine.Draw();
            rightLine.Draw();
            upLine.Draw();
            downLine.Draw();
        }
    } 
}