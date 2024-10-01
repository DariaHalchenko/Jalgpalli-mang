using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    //Klass palli joonistamiseks mänguväljakul
    //Класс для отрисовки мяча на игровом поле
    public class Palli_joonistamine
    {
        private Game _game;
        public Palli_joonistamine(Game game)
        {
            _game = game;
        }
        //Meetod puhastab ekraanilt eelmise palliasendi
        //Метод очищает предыдущую позицию мяча с экрана
        public void Clear()
        {
            Console.SetCursorPosition((int)_game.Ball.X, (int)_game.Ball.Y);
            Console.Write(' ');
        }
        //joonistab palli väljakule (рисует мяч на поле)
        public void Draw()
        {
            Console.SetCursorPosition((int)_game.Ball.X, (int)_game.Ball.Y); //palli asend (позицию мяча)
            Console.ForegroundColor = ConsoleColor.Red; //palli värv (цвет мяча)
            Console.Write('O'); //palli sümbol (символ мяча)
        }
    } 
}