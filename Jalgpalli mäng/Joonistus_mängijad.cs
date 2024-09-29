using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    
    public class Joonistus_mängijad
    {
        private Game _game;
        public Joonistus_mängijad(Game game)
        {
            _game = game;
        }
        public void Draw()
        {
            foreach (var player in _game.HomeTeam.Players)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; //цвет игрока
                Console.SetCursorPosition((int)player.X, (int)player.Y); //позицию игрока
                Console.Write('Y'); //символ игрока
            }

            foreach (var player in _game.AwayTeam.Players)
            {
                Console.ForegroundColor = ConsoleColor.Magenta; //цвет игрока
                Console.SetCursorPosition((int)player.X, (int)player.Y); //позицию игрока
                Console.Write('M'); //символ игрока
            }
        }
    }
}



