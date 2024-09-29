using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    public class Palli_joonistamine
    {
        private Game _game;
        public Palli_joonistamine(Game game)
        {
            _game = game;
        }
        public void Draw()
        {
            Console.SetCursorPosition((int)_game.Ball.X, (int)_game.Ball.Y);
            Console.ForegroundColor = ConsoleColor.Red; // цвет мяча
            Console.Write('O'); //символ мяча
        }
    } 
}