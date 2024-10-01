using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    //Klass staadioni (mänguväljaku) joonistamiseks
    //Класс для отрисовки стадиона (игрового поля)
    public class Staadioni_joonis
    {
        private Game _game;

        public Staadioni_joonis(Game game)
        {
            _game = game;
        }

        //Meetod mänguvälja joonistamiseks(Метод для рисование игрового поля)
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Loome horisontaalsed jooned (Создаем горизонтальные линии )
            HorizontalLine upLine = new HorizontalLine(0, _game.Stadium.Width - 1, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, _game.Stadium.Width - 1, _game.Stadium.Height - 1, '_');
            //Loome vertikaalsed jooned (Создаем вертикальные линии)
            VerticalLine leftLine = new VerticalLine(0, _game.Stadium.Height - 1, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, _game.Stadium.Height - 1, _game.Stadium.Width - 1, '|');
            //Joonistame (Отрисовываем)
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
        }
    } 
}